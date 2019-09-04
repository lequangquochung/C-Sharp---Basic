using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson22
    {
        public static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Input a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(result(a));

        }
        public static bool result(int n) { 
            if(Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20){
                return true;
            }else{
                return false;
            }
        }
    }
}
