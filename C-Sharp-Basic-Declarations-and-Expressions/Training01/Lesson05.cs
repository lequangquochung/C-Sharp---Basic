using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson05
    {
        public static void Main(string[] args)
        {
            int number1, number2, num;
            Console.Write("Input 1: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Input 2: ");
            number2 = int.Parse(Console.ReadLine());
            num = number1;
            number1 = number2;
            number2 = num;
            Console.Write("\n First Number : " + number1);
            Console.Write("\n Second Number : " + number2);
            Console.Read();
        }
    }
}
