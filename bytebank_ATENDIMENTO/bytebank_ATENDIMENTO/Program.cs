using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bitebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Modelos.bytebank.Util;
using System.Collections;
using static bytebank_ATENDIMENTO.bitebank.Exceptions.BiteBankExceptions;

Console.WriteLine("Aula - 4 Array de objetos");

#region Exemplos Arrays em C#
void TestaArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    var contaJurema = new ContaCorrente(874);
    var contaAbreu = new ContaCorrente(873);

    listaDeContas.Adicionar(contaJurema);
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(contaAbreu);
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(874));

    var contaDoAndre = new ContaCorrente(123);
    listaDeContas.Adicionar(contaDoAndre);
    listaDeContas.ExibeLista();

    Console.WriteLine("*************************************");

    listaDeContas.Remover(contaDoAndre);
    listaDeContas.Remover(contaJurema);
    listaDeContas.Remover(contaAbreu);
    listaDeContas.ExibeLista();

    Console.WriteLine("*************************************");

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] -> {conta.Numero_agencia} / {conta.Conta}");
    }



}

// TestaArrayDeContasCorrentes();
#endregion 

Console.WriteLine("Boas vindas ao ByteBank Atendimento!");

new BiteBankAtendimento().AtendimentCliente();

