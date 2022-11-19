using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bytebank_ATENDIMENTO.bitebank.Exceptions.BiteBankExceptions;

namespace bytebank_ATENDIMENTO.bitebank.Atendimento
{
    public class BiteBankAtendimento
    {

        private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
        {
            new ContaCorrente(99) {Saldo = 100, Titular = new Cliente{Cpf="1111", Nome="Pedro", Profissao="Maluco"} },
            new ContaCorrente(99) {Saldo = 200},
            new ContaCorrente(91) {Saldo = 300},
            new ContaCorrente(65) {Saldo = 1000},
            new ContaCorrente(32) {Saldo = 2000},
            new ContaCorrente(1) {Saldo = 3000},
        };

        //List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
        //{
        //    new ContaCorrente(65, "123456-D") {Saldo = 1000},
        //    new ContaCorrente(32, "456321-E") {Saldo = 2000},
        //    new ContaCorrente(1, "789654-F") {Saldo = 3000},
        //};

        //_listaDeContas2.Reverse(); // inverte a ordem
        //_listaDeContas.AddRange(_listaDeContas2); // esse método adiciona uma lista na outra

        public void AtendimentCliente()
        {
            try
            {
                char opcao = '0';
                while (opcao != '6')
                {
                    Console.Clear();
                    Console.WriteLine("*********************************");
                    Console.WriteLine("*******    Atendimento    *******");
                    Console.WriteLine("****  1-  Cadastrar Conta    ****");
                    Console.WriteLine("****  2-  Listar Contas      ****");
                    Console.WriteLine("****  3-  Remover Conta      ****");
                    Console.WriteLine("****  4-  Ordenar Contas     ****");
                    Console.WriteLine("****  5-  Pesquisar Conta    ****");
                    Console.WriteLine("****  6-  Sair do Sistema    ****");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Digite a opção desejada: ");

                    try
                    {
                        opcao = Console.ReadLine()[0];
                    }
                    catch (Exception excecao)
                    {

                        throw new ByteBankException(excecao.Message);
                    }

                    switch (opcao)
                    {
                        case '1':
                            CadastrarConta();
                            break;
                        case '2':
                            ListarContas();
                            break;
                        case '3':
                            RemoverConta();
                            break;
                        case '4':
                            OrdenarContas();
                            break;
                        case '5':
                            PesquisarContas();
                            break;
                        case '6':
                            EncerrarAplicacao();
                            break;
                        default:
                            Console.WriteLine("Opção não implementada.");
                            break;
                    }
                }
            }
            catch (ByteBankException excecao)
            {
                Console.WriteLine($"{excecao.Message}");
            }
        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("***-> Encerrando a Aplicação <-***");
            Console.ReadKey();
        }

        private void PesquisarContas()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("======== Pesquisar Conta ========");
            Console.WriteLine("====================================");
            Console.WriteLine("\n");
            Console.WriteLine("1 - Pesquisar por NUMERO DA CONTA");
            Console.WriteLine("2 - Pesquisar por CPF DO TITULAR");
            Console.WriteLine("3 - Pesquisar por NUMERO DA AGÊNCIA");
            int opcaoPesquisa = int.Parse(Console.ReadLine());

            switch (opcaoPesquisa)
            {
                case 1:
                    {
                        Console.WriteLine("Informe o número da Conta: ");
                        string _numeroConta = Console.ReadLine();
                        ContaCorrente consultaConta = ConsultaNumeroConta(_numeroConta);
                        Console.WriteLine(consultaConta.ToString());
                        Console.ReadKey();
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Informe o número do CPF: ");
                        string _cpf = Console.ReadLine();
                        ContaCorrente consultaCpf = ConsultaNumeroCPF(_cpf);
                        Console.WriteLine(consultaCpf.ToString());
                        Console.ReadKey();
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Informe o número do Agência: ");
                        int _agencia = int.Parse(Console.ReadLine());
                        var contasAgencia = ConsultaNumeroAgencia(_agencia);
                        ExibirListaContas(contasAgencia);
                        Console.ReadKey();
                        break;
                    }

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        private void ExibirListaContas(List<ContaCorrente> contasAgencia)
        {
            if (contasAgencia == null || contasAgencia.Count == 0)
            {
                Console.WriteLine("Nenhuma conta encontrada");
            }
            else
            {
                foreach (var item in contasAgencia)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine("\n");
                }
            }
        }

        private List<ContaCorrente> ConsultaNumeroAgencia(int agencia)
        {
            var consulta = (
                            from conta in _listaDeContas
                            where conta.Numero_agencia == agencia
                            select conta).ToList();
            return consulta;
        }

        private ContaCorrente ConsultaNumeroCPF(string? cpf)
        {
            return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();
        }

        private ContaCorrente ConsultaNumeroConta(string? numeroConta)
        {
            //ContaCorrente conta = null;
            //for (int i = 0; i < _listaDeContas.Count; i++)
            //{
            //    if (_listaDeContas[i].Conta.Equals(numeroConta))
            //    {
            //        conta = _listaDeContas[i];
            //    }
            //}
            //return conta;
            //return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();
            return (from conta in _listaDeContas
                    where conta.Conta.Equals(numeroConta)
                    select conta).FirstOrDefault();
        }

        private void OrdenarContas()
        {
            _listaDeContas.Sort();
            Console.WriteLine("*** Lista de Contas Ordenada ***");
            Console.ReadKey();
        }

        private void RemoverConta()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("======== Remover Conta ========");
            Console.WriteLine("====================================");
            Console.WriteLine("\n");
            Console.WriteLine("Informe o número da Conta: ");
            string numeroConta = Console.ReadLine();
            ContaCorrente conta = null;

            foreach (var item in _listaDeContas)
            {
                if (item.Conta.Equals(numeroConta))
                {
                    conta = item;
                }
            }

            if (conta != null)
            {
                Console.WriteLine($"*** Conta {numeroConta} Removida com sucesso! ***");
                _listaDeContas.Remove(conta);
            }
            else
            {
                Console.WriteLine("++++ CONTA NÃO ENCONTRADA ++++");
            }
            Console.ReadKey();
        }

        private void ListarContas()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("======== Lista de Contas ========");
            Console.WriteLine("====================================");
            Console.WriteLine("\n");
            if (_listaDeContas.Count <= 0)
            {
                Console.WriteLine("*****   NÃO HÁ CONTAS CADASTRADAS   *****");
                Console.ReadKey();
                return;
            }
            else
            {
                foreach (ContaCorrente item in _listaDeContas)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine($">>>>>>>>>><<<<<<<<<<<");
                    Console.WriteLine("\n");
                    Console.ReadKey();
                }
            }
        }

        private void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("======== Cadastro de Contas ========");
            Console.WriteLine("====================================");
            Console.WriteLine("\n");
            Console.WriteLine("====== Informe dados da conta ======");
            
            Console.WriteLine("Numero da Agência: ");
            int numeroAgencia = int.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(numeroAgencia);

            Console.WriteLine($"Número da nova conta {conta.Conta}");

            Console.WriteLine("Informe o saldo Inicial: ");
            conta.Saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe nome do Titular: ");
            conta.Titular.Nome = Console.ReadLine();

            Console.WriteLine("Informe CPF do Titular: ");
            conta.Titular.Cpf = Console.ReadLine();

            Console.WriteLine("Informe profissão do Titular: ");
            conta.Titular.Profissao = Console.ReadLine();

            _listaDeContas.Add(conta);
            Console.WriteLine("-> Conta cadastra com sucesso! <-");
            Console.WriteLine($"Seja bem vindo {conta.Titular.Nome}");

            Console.ReadKey();

        }
    }
}
