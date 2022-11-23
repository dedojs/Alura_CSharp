using ByteBankIO;
using System.Text;

partial class Program
{
    static void CriarARquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaString = "456, 7895, 4785.40, Andre Luis";
            var encoding = Encoding.UTF8;
            var bytes = encoding.GetBytes(contaString);
            fluxoArquivo.Write(bytes, 0, bytes.Length);
            Console.WriteLine("Arquivo criado com sucesso");
        }
    }

    static void CriarArquivoComWriter()
    {
        var caminhoArquivo = "contasExportadas1.csv";

        using(var fluxoArquivo = new FileStream(caminhoArquivo, FileMode.CreateNew))
        using (var escritor = new StreamWriter(fluxoArquivo))
        {
            escritor.Write("123,963852,4987.00,Lara Sousa");
            Console.WriteLine("Arquivo gravado com sucesso!");
        }
    }

    static void TestaEscrita()
    {
        var caminhoArquivo = "teste.txt";

        using (var fluxoArquivo = new FileStream(caminhoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoArquivo))
        {
            for (int i = 0; i < 1000; i++)
            {
                escritor.WriteLine($"Linha{i}");
                escritor.Flush(); // Despeja o buffer para o Stream
                Console.WriteLine($"Linha {i} foi escrita");
            }
        }
    }

    //static void EscritaBinaria()
    //{
    //    var caminhoArquivo = "testeEscrita.txt";

    //    using (var fluxoArquivo = new FileStream(caminhoArquivo, FileMode.Create))
    //    using (var escritor = new StreamWriter(fluxoArquivo))
    //    {
    //        escritor.WriteLine(true);
    //        escritor.WriteLine(false);
    //        escritor.WriteLine(454545454545);
    //        Console.WriteLine("Arquivo gravado com sucesso!");
    //    }
    //}


}






