using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    class Employe
    {
        public int id;
        public string name;
        public double salary;

        public Employe(int Id, string Name, double Salary)
        {
            id = Id;
            name = Name;
            salary = Salary;
        }

        public void SalaryIncrease(double porcentage)
        {
            salary = salary + ((salary * porcentage) / 100);
        }

        public override string ToString()
        {
            return $"{id}, {name}, {salary}";
        } 
    }
}
