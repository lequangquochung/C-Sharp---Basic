using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    class Lesson44
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string : ");
            string str = Console.ReadLine();
            var result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0) result += str[i];
            }
            Console.WriteLine(result);
        }
    }
}
