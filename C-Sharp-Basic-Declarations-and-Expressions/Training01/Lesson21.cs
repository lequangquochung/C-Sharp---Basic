using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson21
    {
        public static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("\nInput  :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a == 20 || b == 20 || (a + b == 20));
        }
    }
}
