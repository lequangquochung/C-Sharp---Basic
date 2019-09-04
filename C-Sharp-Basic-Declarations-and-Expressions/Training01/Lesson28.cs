using System;
using System.Collections.Generic;
using System.Text;

namespace Training01
{
    public class Lesson28
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string strRever = ReverseString(str);
            Console.WriteLine(strRever);        }
        public static string ReverseString(string str)
        {
            char[] arr = str.ToCharArray(); // chuỗi thành mảng ký tự
            Array.Reverse(arr); // đảo ngược mảng
            return new string(arr); // trả về chuỗi mới sau khi đảo mảng
        }
    }
}
