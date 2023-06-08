using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using _2._5;
namespace _2._5
{

    

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
