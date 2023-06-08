using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    class proga
    {
        private string name;
        private string surname;

        public proga() { name = "Неизвестно"; surname = "Неизвестно"; }
        public proga(string name, string surname) { this.name = name; this.surname = surname; }

        public void GetPrint()
        {
            Console.WriteLine($"Имя: {name}  Фамилия: {surname}");
        }

        ~proga()
        {
            Console.WriteLine($"{name} has deleted");
        }

    }
}
