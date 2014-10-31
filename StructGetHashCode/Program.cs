using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var a1 = new KeyValuePair<int, int>(1, 2);
        var a2 = new KeyValuePair<int, int>(1, 3);
        Console.WriteLine(a1.GetHashCode() == a2.GetHashCode());
        var b1 = new KeyValuePair<int, string>(1, "x");
        var b2 = new KeyValuePair<int, string>(1, "y");
        Console.WriteLine(b1.GetHashCode() == b2.GetHashCode());
    }
}