using System;
using System.Collections.Generic;
namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employe> Lista = new List<Employe>();

            Console.WriteLine("How many employees will be registered?:");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Employe Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Employe Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Employe Salary:");
                double salary = double.Parse(Console.ReadLine());


                Employe Funcionário = new(id, name, salary);
                Lista.Add(Funcionário);
            }

            Console.WriteLine("Enter the Employee id that wil have salary increase:");
            int LocateId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percentage:");
            double percentage = double.Parse(Console.ReadLine());

            foreach (var item in Lista)
            {
                if(item.id == LocateId)
                {
                    item.SalaryIncrease(percentage);
                }
            }

            Console.WriteLine("Updated list of employees:");

            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }





        }
    }
}
