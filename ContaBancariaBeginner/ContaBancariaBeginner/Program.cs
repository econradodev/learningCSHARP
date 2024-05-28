using System;
using System.Globalization;

namespace ContaBancariaBeginner
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o número da conta: ");
            int NumeroDaConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string Nome = Console.ReadLine();
            double Saldo = 0;

            Conta conta = new Conta(NumeroDaConta, Nome, Saldo);

            Console.Write("Haverá depósito inicial (s/n)? ");
            char Verificador = char.Parse(Console.ReadLine());

            if (Verificador == 'n')
            {
                Console.WriteLine();
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);

            } else if (Verificador == 's')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                conta._saldo = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);

            }

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double Valor = double.Parse(Console.ReadLine());
            conta.AdicionarSaldo(Valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            Valor = double.Parse(Console.ReadLine());
            conta.Saque(Valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);




        }
    }
}
