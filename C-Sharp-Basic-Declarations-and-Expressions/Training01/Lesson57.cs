using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    class Lesson57
    {
        public static int adjacent_Elements_Product(int[] input_Array)
        {
            int max = 0;
            for (int i = 1; i < input_Array.Length;)
            {
                max = Math.Max(max, input_Array[i - 1] * input_Array[i++]);
            }
            return max;
        }

        public static void Main()
        {
            Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, 4, 5, 2 }));
            Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, -4, 5, 2 }));
            Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 0, -4, 0, 2 }));
        }
    }
}
