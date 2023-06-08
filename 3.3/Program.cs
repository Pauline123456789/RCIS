using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using _3._3;

namespace _3._3
{  
    internal class Program
    { 

        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            calculation.SetCalculationLine("Polina");
            calculation.GetCalculationLine();
            calculation.SetLastSymbolCalculationLine('o');
            calculation.GetCalculationLine();
            calculation.GetLastSymbol();
            calculation.DeleteLastSymbol();
            calculation.GetCalculationLine();

        }
    }
}
