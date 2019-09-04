using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson18
    {
        public static void Main()
        {
            int x, y;
            Console.WriteLine("Input X : ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Input Y : ");
            y = int.Parse(Console.ReadLine());

            if(x<0 && y>0 || x>0 && y < 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
