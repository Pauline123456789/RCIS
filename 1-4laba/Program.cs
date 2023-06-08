using System;

namespace ConsoleApp1
{

    public class Program
    {
        public static void Main(string[] args)
        {
            {
                int counter = 0;
                string S_string = "pv";
                string J_string = "ppvvssh";
                
                foreach (char y in S_string) { 
                    foreach (char g in J_string)
                    {
                        if (y == g) {
                        counter++;
                        }

                    }
                }

                Console.WriteLine(counter);
            }
        }
    }
}
