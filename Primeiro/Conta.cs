using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Conta
    {
        private readonly double _taxa = 5.0;
        public double SaldoAcc { get; private set; }
        public string TitularAcc { get; set; }
        public int NumeroAcc { get; private set; }

        public Conta(int numero, string titular)
        {
            NumeroAcc = numero;
            TitularAcc = titular;
        }
        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            SaldoAcc = SaldoAcc + valor;
        }
        public void Saque(double valor)
        {
            SaldoAcc = SaldoAcc - valor - _taxa;
        }
        public override string ToString()
        {
            return "Dados da conta:\n"
                + "Conta " + NumeroAcc
                + ", Titular: " + TitularAcc
                + ", Saldo: $" + SaldoAcc.ToString("F2")
                + "\n";
        }
    }
}
