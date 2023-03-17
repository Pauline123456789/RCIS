
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Worker
    {
        public string name, surname;
        public int days, rate;

        public void GetSalary()
        {
            Console.WriteLine($"ЗАРПЛАТА -  {days * rate}");
        }
    }
    public class Program
    {

        public static void Main(string[] args)
        {
            Worker Paulina = new Worker();
            Paulina.name = "Paulina";
            Paulina.surname = "Novoseltseva";
            Paulina.days = 7;
            Paulina.rate = 150;
            Paulina.GetSalary();
        }
    }
}
