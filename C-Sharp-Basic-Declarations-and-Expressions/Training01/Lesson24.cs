using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson24
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);
        }
    }
}
