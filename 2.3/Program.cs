using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using _2._3;

namespace ConsoleApp1
{

    

    public class Program
    {

        public static void Main(string[] args)
        {
            Storage Number = new Storage();

            bool Worker = true;
            while (Worker)
            {
                Console.WriteLine("Выберите действие:\n 1 - для изменения чисел \n 2 - вывести числа на экранчик \n 3 - для вывода суммы этих чисел \n 4 - для нахождения наибольшего числа \n 5 - для закрытия программы ");
                string Str = Console.ReadLine();
                switch (Str)
                {
                    case "1":

                        Number.SetNewNumber();
                        break;
                    case "2":

                        Number.GetPrint();
                        break;
                    case "3":
                        Number.GetSumm();
                        break;
                    case "4":
                        Number.GetSravnenie();
                        break;
                    case "5":

                        Worker = false;
                        break;
                }

            }
        }
    }
}
