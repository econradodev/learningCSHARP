using System;
using System.Globalization;
using System.Net.Security;

namespace EstudoInicial
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);


            Console.WriteLine(p);


        }
    }
}
