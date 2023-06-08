
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _3._2;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Worker Paulina = new Worker();
            
            Paulina.SetNew("Paulina","Novoseltseva",100,20);
            Paulina.GetPrint();
        }
    }
}
