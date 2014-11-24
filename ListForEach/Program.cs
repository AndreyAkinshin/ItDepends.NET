using System;
using System.Collections.Generic;

#if NET_4_5
[assembly: global::System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5", FrameworkDisplayName = ".NET Framework 4.5")]
#endif

public class Program
{
    public static void Main()
    {
        var list = new List<int> { 1, 2 };
        try
        {
            list.ForEach(i =>
            {
                if (i == 1)
                    list.Add(3);
                Console.WriteLine(i);
            });
        }
        catch (Exception e)
        {
            Console.WriteLine(e.GetType().Name);
        }
    }
}