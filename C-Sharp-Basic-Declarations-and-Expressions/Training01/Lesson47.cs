using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson47
    {
        public static void Main()
        {
            int[] arrayNum = new int[10];            
            int sum = 0;
            for(int i = 0; i < arrayNum.Length; i++)
            {
                Console.WriteLine("Array[" + i + "] = ");
                arrayNum[i] = int.Parse(Console.ReadLine());
                
                sum += arrayNum[i];
            }
            Console.WriteLine(sum);
        }
    }
}
