using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson09
    {
        public static void Main()
        {

            double num1, num2, num3, num4;

            Console.WriteLine("Num1 : ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Num2 : ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Num3 : ");
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Num4 : ");
            num4 = Convert.ToDouble(Console.ReadLine());

            double avg = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine(avg);

        }
    }
}
