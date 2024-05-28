using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaBeginner
{
    internal class Conta
    {
        private int _numeroDaConta;
        private string _nome;
        public double _saldo;

        public Conta() { }

        public Conta(int numeroDaConta, string nome, double saldo)
        {
            _numeroDaConta = numeroDaConta;
            _nome = nome;
            _saldo = saldo;
        }

        public void AdicionarSaldo(double valor)
        {
            _saldo += valor;
        }

        public void Saque(double valor)
        {
            _saldo -= valor + 5.00;
        }

        public override string ToString()
        {
            return "Conta " 
                + _numeroDaConta
                + ", Titular: "
                + _nome
                + ", Saldo: $ "
                + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
