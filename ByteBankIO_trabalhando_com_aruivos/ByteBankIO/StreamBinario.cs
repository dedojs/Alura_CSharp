using ByteBankIO;
using System.Text;

partial class Program
{
    static void EscritaBinaria()
    {
        using (var fs = new FileStream("contacorrente.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456);
            escritor.Write(546544);
            escritor.Write(4000.50);
            escritor.Write("Gustavo Braga");
            Console.WriteLine("Escrita binária criada com sucesso!");
        }
    }

    static void LeituraBinaria()
    {
        using (var fs = new FileStream("contacorrente.txt", FileMode.Open))
        using (var leitor = new BinaryReader(fs))
        {
            var agencia = leitor.ReadInt32();
            var conta = leitor.ReadInt32();
            var valor = leitor.ReadDouble();
            var titular = leitor.ReadString();

            Console.WriteLine($"{agencia} / {conta} => {titular} saldo: {valor}");
        }
    }




}