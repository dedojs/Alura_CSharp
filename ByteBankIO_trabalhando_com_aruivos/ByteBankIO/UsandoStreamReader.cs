
using ByteBankIO;
using System.Text;

partial class Program
{
    public static void CriandoContas(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);
            //var linha = leitor.ReadLine(); // 1 linha
            //var texto = leitor.ReadToEnd(); // lê todo texto de uma vez
            //var numero = leitor.Read(); //1 caracther

            // dessa forma lê linha a linha, até o fim
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);

                var msg = $"Agência {contaCorrente.Agencia} / Conta número {contaCorrente.Conta}, Titular: {contaCorrente.Titular.Nome}, Saldo: {contaCorrente.Saldo}";
                Console.WriteLine(msg);
            }

        }
        Console.ReadLine();
    }

    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        //375 4644 2483.13 Jonatan
        var campo = linha.Split(',');
        var agencia = int.Parse(campo[0]);
        var conta = int.Parse(campo[1]);
        var saldo = double.Parse(campo[2].Replace('.', ','));
        var titular = new Cliente(campo[3]);

        var resultado = new ContaCorrente(conta, agencia, titular);
        resultado.Depositar(saldo);
        resultado.Titular = titular;

        return resultado;
    }
}






