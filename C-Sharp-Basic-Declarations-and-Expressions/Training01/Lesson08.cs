using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson08
    {
        public static void Main()
        {
            int x;

            Console.WriteLine("Enter a number:");
            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int product = x * i; Console.WriteLine(x + " x " + i + " = " + product);
            }

        }
    }
}

