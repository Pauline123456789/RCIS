
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _3._1;
namespace ConsoleApp1
{
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
