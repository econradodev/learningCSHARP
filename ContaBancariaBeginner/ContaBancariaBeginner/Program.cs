using System;
using System.Globalization;

namespace ContaBancariaBeginner
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();

            Conta conta;

            Console.Write("Haverá depósito inicial (s/n)? ");
            char verificador = char.Parse(Console.ReadLine());

           if (verificador == 's' || verificador == 'S')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                conta = new Conta(numeroDaConta, nome, saldo);
                Console.WriteLine();
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);

            } else
            {
                conta = new Conta(numeroDaConta, nome);
                Console.WriteLine();
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);
            }

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());
            conta.AdicionarSaldo(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);




        }
    }
}
