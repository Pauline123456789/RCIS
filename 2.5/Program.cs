using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2._5
{

    class proga {
        private string name;
        private string surname;

        public proga() { name = "Неизвестно"; surname = "Неизвестно"; }
        public proga(string name,string surname) { this.name = name; this.surname = surname; }

        public void GetPrint()
        {
            Console.WriteLine($"Имя: {name}  Фамилия: {surname}");
        }

        ~proga()
        {
            Console.WriteLine($"{name} has deleted");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            proga men1 = new proga("Paulina","Novoseltseva");
            proga men2 = new proga();
            men1.GetPrint();
            men2.GetPrint();


        }
    }
}
