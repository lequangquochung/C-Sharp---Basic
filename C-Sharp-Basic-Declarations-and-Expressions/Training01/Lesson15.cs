using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson15
    {
        public static void Main()
        {
            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 9));
            Console.WriteLine(remove_char("w3resource", 0));
        }
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
    
}
