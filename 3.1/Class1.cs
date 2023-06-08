using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
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
}
