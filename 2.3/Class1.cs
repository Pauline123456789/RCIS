using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Storage
    {
        private int number1, number2;

        public void GetPrint()
        {
            Console.WriteLine("Первое число {0}\nВторое число {1}", number1, number2);
        }

        public void SetNewNumber()
        {
            Console.WriteLine("Введите новое первое число");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            number2 = Convert.ToInt32(Console.ReadLine());
        }

        public void GetSumm()
        {
            Console.WriteLine(number1 + number2);
        }

        public void GetSravnenie()
        {
            if (number1 > number2)
            {
                Console.WriteLine("Наибольшее {0}", number1);
            }
            else if (number1 < number2)
            {
                Console.WriteLine("Наибольшее {0}", number2);
            }
            else
            {
                Console.WriteLine("они равны");
            }
        }
    }
}
