using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2._2;
namespace ConsoleApp1
{
   


    public class Program
    {

        public static void Main(string[] args)
        {
            Train poezd1 = new Train();
            poezd1.pynkt = "NOVOSIBIRSK";
            poezd1.nomer = 1;
            poezd1.vremia = "15:00";

            Train poezd2 = new Train();
            poezd2.pynkt = "TOMSK";
            poezd2.nomer = 2;
            poezd2.vremia = "22:00";

            Train poezd3 = new Train();
            poezd3.pynkt = "OMSK";
            poezd3.nomer = 3;
            poezd3.vremia = "21:00";


            while (true)
            {

                Console.WriteLine("Введите номер поезда от 1 до 3");
                string chislo = Console.ReadLine();

                switch (chislo)
                {
                    case "1":
                        poezd1.writeInConsoleInfo(poezd1.pynkt, poezd1.vremia, poezd1.nomer);
                        break;
                    case "2":
                        poezd2.writeInConsoleInfo(poezd2.pynkt, poezd2.vremia, poezd2.nomer);
                        break;
                    case "3":
                        poezd3.writeInConsoleInfo(poezd3.pynkt, poezd3.vremia, poezd3.nomer);
                        break;
                }
            }
        }
    }
}
