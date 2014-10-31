using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var numbers = new int[] { 1, 2, 3 };
        var actions = new List<Action>();
        foreach (var number in numbers)
            actions.Add(() => Console.WriteLine(number));
        foreach (var action in actions)
            action();
    }
}