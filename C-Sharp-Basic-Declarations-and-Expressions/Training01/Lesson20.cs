using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Result(40, 30));
            Console.WriteLine(Result(10, 30));
            Console.WriteLine(Result(0, 30));

        }
        public static int Result(int a, int b)
        {            
            if (a > b)
            {
                return (a - b) * 2;
            }
            else
            {                
                return Math.Abs(a-b);
            }
        }
    }
}
