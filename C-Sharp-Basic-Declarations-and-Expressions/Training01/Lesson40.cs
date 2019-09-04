using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson40
    {
        public static void Main()
        {
            Console.WriteLine("\nInput first integer:");
            int x =int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = int.Parse(Console.ReadLine());
            int n = 20;
            var val1 = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);
            Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
        }
    }
}
