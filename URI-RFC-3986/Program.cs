using System;

#if NET_4_5
[assembly: global::System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5", FrameworkDisplayName = ".NET Framework 4.5")]
#endif

public class Program
{
    public static void Main()
    {
        new Program().Run();
    }

    public void Run()
    {
        var uri = new Uri("http://localhost/%2F1");
        Console.WriteLine(uri.OriginalString);
        Console.WriteLine(uri.AbsoluteUri);
    }
}
