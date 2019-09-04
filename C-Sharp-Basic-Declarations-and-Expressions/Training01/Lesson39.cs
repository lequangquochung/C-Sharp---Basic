using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    class Lesson39
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Input a :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input b :");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input c :");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Largest of three: " + Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("Lowest of three: " + Math.Min(a, Math.Min(b, c)));
        }
    }
}
