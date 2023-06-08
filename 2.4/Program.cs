using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using _2._4;
namespace ConsoleApp1
{
   


    public class Program
    {
        public static void Main(string[] args)
        {
            Storage Number = new Storage();
            bool Work = true;
            while (Work)
            {
                Console.WriteLine("Введите:\n 1 для создания счетчика со своим начальным числом \n 2 для СОЗДАНИЯ СЧЕТЧИКА СО СЛУЧАЙНЫМ ЧИСЛОМ \n 3 для вывода числа \n 4 увеличить на один \n 5 уменьшить на один");
                string a = Console.ReadLine();

                switch (a)
                {
                    case "1":
                        Console.WriteLine("Ввдите начальное число");
                        Number.SetP(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "2":
                        Number.SetR();
                        break;
                    case "3":
                        Number.GetPrint();
                        break;
                    case "4":
                        Number.plus();
                        break;
                    case "5":
                        Number.minus();
                        break;

                }
            }
        }
    }
}
