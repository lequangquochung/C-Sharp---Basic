using System;
using System.Collections.Generic;
public class Lesson30
{
    public static void Main()
    {
        string hexval = "4B0";
        Console.WriteLine("Hexadecimal number: " + hexval);
        int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine("Convert to-");
        Console.WriteLine("Decimal number: " + decValue);
    }
}