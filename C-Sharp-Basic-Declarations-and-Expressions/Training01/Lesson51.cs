using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson51
    {
        public static void Main()
        {
            int[] arrayNum = new int[10];
            int max = arrayNum[0];
            for (int i = 0; i < arrayNum.Length; i++)
            {
                Console.WriteLine("Array[" + i + "] = ");
                arrayNum[i] = int.Parse(Console.ReadLine());   
                if(max < arrayNum[i])
                {
                    max = arrayNum[i];
                }
            }
            Console.WriteLine(max);
            
        }
    }
}
