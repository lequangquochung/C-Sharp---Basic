using System;
using System.Collections.Generic;
using System.IO;

public class Lesson29
{
    public static void Main()
    {
        FileInfo f = new FileInfo("Lesson29.cs");
        Console.WriteLine("\nSize of a file: " + f.Length.ToString());
    }
}