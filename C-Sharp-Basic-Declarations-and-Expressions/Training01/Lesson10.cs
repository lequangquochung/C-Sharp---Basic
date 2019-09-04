using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson10
    {
        public static void Main()
        {
            int num1, num2, num3;

            Console.Write("num1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("num2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("num3: ");
            num3 = int.Parse(Console.ReadLine());

            Console.Write("Result {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
                num1, num2, num3, ((num1 + num2) * num3), (num1 * num2 + num2 * num3));
        }
    }
}
