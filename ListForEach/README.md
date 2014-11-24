## Description

The code:

```cs
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
```

## Runs

* **ms-4.0** (MS.NET 4.0):
```
1
2
3
```

* **ms-4.5** (MS.NET 4.5):
```
1
InvalidOperationException
```

* **mono-3.10.0** (Mono 3.10.0):
```
1
2
3
```

## Links

* [.NET Web Development and Tools Blog: All about <httpRuntime targetFramework>](http://blogs.msdn.com/b/webdev/archive/2012/11/19/all-about-httpruntime-targetframework.aspx)