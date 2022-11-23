
using ByteBankIO;
using System.Text;

partial class Program
{
    static void SimpleReadFile()
    {
        var linhas = File.ReadAllLines("contas.txt");

        foreach (var linha in linhas)
        {
            Console.WriteLine(linha);
        }

    }

    static void SimpleReadBytes()
    {
        var bytes = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"O arquivo contas contas.txt possui {bytes.Length} bytes");
    }

    static void SimpleWriteInFile()
    {
        File.WriteAllText("nomeDoArquivo.txt", "Testando texto escrito direto da função");
    }


}