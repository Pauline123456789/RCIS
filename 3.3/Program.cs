﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace _3._3
{  class Calculation {
        private string calculationLine;

        public void SetCalculationLine(string calculationLine) {
            this.calculationLine = calculationLine;
        }

        public void SetLastSymbolCalculationLine(char a) {
            calculationLine = calculationLine + a;
        }

        public void GetCalculationLine() {
        Console.WriteLine(calculationLine);
        }

        public void GetLastSymbol() {
            char a = 'h';
            foreach (char item in calculationLine)
            {
                a = item;
            }
            Console.WriteLine(a);
        }

        public void DeleteLastSymbol() {
            calculationLine = calculationLine.Substring(0, calculationLine.Length - 1); ;
        }





    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            calculation.SetCalculationLine("losto");
            calculation.GetCalculationLine();
            calculation.SetLastSymbolCalculationLine('o');
            calculation.GetCalculationLine();
            calculation.GetLastSymbol();
            calculation.DeleteLastSymbol();
            calculation.GetCalculationLine();

        }
    }
}
