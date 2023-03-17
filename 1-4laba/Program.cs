using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            {
                int setchik = 0;
                string s_stroka = "pv";
                string j_stroka = "ppvvssh";
                
                foreach (char y in s_stroka) { 
                    foreach (char g in j_stroka)
                    {
                        if (y == g) {
                        setchik++;
                        }

                    }
                }

                Console.WriteLine(setchik);
            }
        }
    }
}
