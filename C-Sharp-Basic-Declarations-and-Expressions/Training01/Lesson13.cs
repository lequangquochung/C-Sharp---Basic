using System;

namespace Training01
{
    public class Lesson13
    {
        public static void Main()
        {
            int num;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0}{0}{0}", num);
        }
    }
}
