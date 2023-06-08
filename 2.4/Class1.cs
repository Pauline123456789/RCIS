using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4
{
    class Storage
    {
        private int number;

        public void SetP(int number)
        {
            this.number = number;
        }

        public void SetR()
        {
            Random rnd = new Random();
            number = rnd.Next(100);
        }

        public void GetPrint()
        {
            Console.WriteLine($"Ваше текущее значение: {number}");

        }
        public void writeInConsoleInfo(int scetchik1)
        {
            Console.WriteLine(scetchik1);
        }

        public void plus()
        {
            number++;
        }

        public void minus()
        {
            number--;
        }


    }
}
