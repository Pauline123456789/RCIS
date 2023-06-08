using System;

namespace ConsoleApp1
{
    public class Program
    {


        public static void Main(string[] args)
        {
            string str;
            int[] nums = { 2, 3, 5, 7, 4, 2 };
            bool a = false;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 1+i; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        a = true;
                    }
                }
            }
            if (a == false)
            {
                str = "False";
            }
            else
            {
                str = "True";
            }

            Console.WriteLine(str);
        }
    }
}
