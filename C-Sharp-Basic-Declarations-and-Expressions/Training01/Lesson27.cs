﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson27
    {
        public static void Main()
        {
            Console.Write("Input  a number(integer): ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;           
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}