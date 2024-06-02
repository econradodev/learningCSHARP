using System.Collections.Generic;
using System.Globalization;

namespace PraticandoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int qnt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qnt; i++)
            {
                Console.WriteLine("Employee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));

                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncreased = int.Parse(Console.ReadLine());

            int index = list.FindIndex(x => x.Id == idIncreased);

            if (index >= 0)
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine());
                list[index].IncreaseSalary(percent);
            }
            else
            {
                Console.WriteLine("This id doesn't exist!");
            }

            Console.WriteLine();

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp);
            }

        }
    }
}

