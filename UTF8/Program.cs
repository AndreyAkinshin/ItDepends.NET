using System;
using System.ComponentModel;
using System.Linq;
using System.Text;

[Description(Value)]
public class Program
{
    const string Value = "X\ud800Y";

    public static void Main()
    {
        var description = (DescriptionAttribute)typeof(Program).
            GetCustomAttributes(typeof(DescriptionAttribute), true)[0];
        DumpString("Attribute", description.Description);
        DumpString("UTF8->String", Encoding.UTF8.GetString(new byte[] { 0x58, 0xED, 0xA0, 0x80, 0x59 }));
        DumpBytes("String->UTF-8", Encoding.UTF8.GetBytes(Value));
    }

    private static void DumpString(string name, string text)
    {
        Console.Write("{0}: ", name);
        if (text != null)
        {
            var utf16 = text.Select(c => ((uint)c).ToString("x4"));
            Console.WriteLine(string.Join(" ", utf16));
        }
        else
            Console.WriteLine("null");
    }

    private static void DumpBytes(string name, byte[] bytes)
    {
        Console.WriteLine("{0}: {1}", name, string.Join(" ", bytes.Select(b => b.ToString("x2"))));
    }
}