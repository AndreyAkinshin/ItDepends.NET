## Description

The code:

```cs
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
```

## Runs

* **ms** (Windows, MS compiler, `csc.exe Program.cs`):
```
Attribute: 0058 0059 fffd fffd 0000
UTF8->String: 0058 fffd fffd 0059
String->UTF-8: 58 ef bf bd 59
```

* **mono** (Linux, Mono compiler 3.10.0, `mcs Program.cs`):
```
Attribute: null
UTF8->String: 0058 fffd fffd fffd 0059
String->UTF-8: 58 59 bf bd 00
```

## Links

* [Jon Skeet: When is a string not a string?](http://codeblog.jonskeet.uk/2014/11/07/when-is-a-string-not-a-string)
* [Andrey Akinshin: About UTF-8 conversions in Mono](http://aakinshin.blogspot.com/2014/11/mono-utf8-conversions.html)