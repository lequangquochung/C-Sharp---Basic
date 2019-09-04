using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson14
    {
        public static void Main()
        {
            Console.Write("Enter the amount of celsius: ");
            int C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("K = {0}", C + 273);
            Console.WriteLine("F = {0}", C * 18 / 10 + 32);
        }
    }
}
