using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_
{
    class Student
    {
        public string familia, data;
        public int nomer;
        public int[] progress;

        public void writeInConsoleInfo(string familia, string data, int nomer, int[] progress)
        {
            Console.WriteLine("Фамилия: {0}\nДень рождение: {1}\nГруппа: {2}\n", familia, data, nomer);
            Console.WriteLine("Успеваемость:");
            foreach (int i in progress)
            {
                Console.Write(i + " ");
            }
        }


    }
}
