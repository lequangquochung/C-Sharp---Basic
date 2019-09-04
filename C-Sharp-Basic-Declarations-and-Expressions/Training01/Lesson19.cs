using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson19
    {
        public static int Main()
        {
            int a, b, sum;
            Console.WriteLine("Input a :");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input b :");
            b = int.Parse(Console.ReadLine());          
            
            if (a == b)
            {
                sum = (a + b) *3;
            }
            else
            {
                sum = a + b;
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}
