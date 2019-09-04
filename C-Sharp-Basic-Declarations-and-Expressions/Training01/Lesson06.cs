using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson06
    {
        public static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Input Num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input Num2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Input Num3: ");
            num3 = int.Parse(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine(result);
        }

    }
}
