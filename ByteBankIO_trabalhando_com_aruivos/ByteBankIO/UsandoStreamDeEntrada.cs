using ByteBankIO;
using System.Text;

partial class Program
{
    static void UsandoStreamDeEntrada()
    {
        using var fluxoEntrada = Console.OpenStandardInput();
        using var fs = new FileStream("entradaConsole.txt", FileMode.Create);
        var buffer = new byte[1024];
        Console.WriteLine("Fala comigo! Escreva o que deseja!");
        while (true)
        {
            var bytesLidos = fluxoEntrada.Read(buffer, 0, 1024);
            fs.Write(buffer, 0, bytesLidos);
            fs.Flush();
            Console.WriteLine($"Bytes lidos na console: {bytesLidos}");
        }

    }


}






