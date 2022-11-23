using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO
{
    public class ContaCorrente
    {
        public int Conta { get; }
        public int Agencia { get; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public ContaCorrente(int conta, int agencia, Cliente titular)
        {
            this.Conta = conta;
            this.Agencia = agencia;
            this.Titular = titular;
        }

        public void Depositar(double value)
        {
            Saldo += value;
        }
    }
}
