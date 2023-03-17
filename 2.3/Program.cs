using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    class Storage
    {
        private int number1, number2;

        public void GetPrint()
        {
            Console.WriteLine("Первое число {0}\nВторое число {1}", number1, number2);
        }

        public void SetNewNumber() {
            Console.WriteLine("Введите новое первое число");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            number2 = Convert.ToInt32(Console.ReadLine());
        }

        public void GetSumm() {
        Console.WriteLine(number1+ number2);
        }

        public void GetSravnenie() {
            if (number1 > number2)
            {
                Console.WriteLine("Наибольшее {0}", number1);
            }
            else if (number1 < number2)
            {
                Console.WriteLine("Наибольшее {0}", number2);
            }
            else {
                Console.WriteLine("они равны");
            }
        }
    }

    public class Program
    {

        public static void Main(string[] args)
        {
            Storage pl = new Storage();

            bool b = true;
            while (b)
            {
                Console.WriteLine("Выберите действие:\n 1 - для изменения чисел \n 2 - вывести числа на экранчик \n 3 - для вывода суммы этих чисел \n 4 - для нахождения наибольшего числа \n 5 - для закрытия программы ");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":

                        pl.SetNewNumber();
                        break;
                    case "2":

                        pl.GetPrint();
                        break;
                    case "3":
                        pl.GetSumm();
                        break;
                    case "4":
                        pl.GetSravnenie();
                        break;
                    case "5":

                        b = false;
                        break;
                }

            }
        }
    }
}
