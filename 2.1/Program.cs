using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using Student_;

namespace ConsoleApp1
{
    

    public class Program
    {

        public static void Main(string[] args)
        {
            Student poulina = new Student();
            poulina.familia = "Novoseltseva";
            poulina.data = "12.10.2003";
            poulina.nomer = 621;
            poulina.progress = new[] { 4, 3, 5, 4, 3 };

            
            bool rabota = true;
            while (rabota)
            {
                Console.WriteLine("Введите 1 для вывода, 2 для изменения данных");
                string a = Console.ReadLine();

                switch (a)
                {
                    case "1":
                        poulina.writeInConsoleInfo(poulina.familia, poulina.data, poulina.nomer,
                            poulina.progress);
                        
                        break;
                    case "2":
                        Console.WriteLine("Введите 1 для изменения фамилии, 2 дня рождения, 3 группы, 0 для вывода");
                        string b = Console.ReadLine();
                        {
                            switch (b)
                            {
                                case "1":
                                    Console.WriteLine("Введите новую фамилию");
                                    string newfamilia = Console.ReadLine();
                                    poulina.familia = newfamilia;
                                    break;
                                case "2":
                                    Console.WriteLine("Введите новую дату дня рождения");
                                    string newdr = Console.ReadLine();
                                    poulina.data = newdr;
                                    break;
                                case "3":
                                    Console.WriteLine("Введите новую группу");
                                    int newnomer = Convert.ToInt32(Console.ReadLine());
                                    poulina.nomer = newnomer;
                                    break;
                                case "0":
                                    poulina.writeInConsoleInfo(poulina.familia, poulina.data, poulina.nomer,
                                        poulina.progress);
                                    
                                    break;
                            }
                        }
                        break;

                }
            }

        }
    }
}
