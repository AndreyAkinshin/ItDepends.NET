## Description

The code:

```cs
var numbers = new int[] { 1, 2, 3 };
var actions = new List<Action>();
foreach (var number in numbers)
    actions.Add(() => Console.WriteLine(number));
foreach (var action in actions)
    action();
```

It prints `1 2 3` for new C# compiler versions (C#5+) and `3 3 3` for old versions. The `langversion` option does not affect on the behavior in new compilers.

## Runs

* **mono-2.4.4** (Linux, Mono compiler 2.4.4, `gmcs Program.cs`): `3 3 3`
* **mono-3.10.0** (Linux, Mono compiler 3.10.0, `mcs Program.cs`): `1 2 3`
* **mono-3.10.0-lang4** (Linux, Mono compiler 3.10.0, `mcs -langversion:4 Program.cs`): `1 2 3`
* **ms-csc3.5** (Windows, MS compiler 3.5, `csc.exe Program.cs`): `3 3 3`
* **ms-csc4.0** (Windows, MS compiler 4.0, `csc.exe Program.cs`): `1 2 3`
* **ms-csc4.0-lang4** (Windows, MS compiler 4.0, `csc.exe /langversion:4 Program.cs`): `1 2 3`

## Links

* [Eric Lippert: Closing over the loop variable considered harmful](http://blogs.msdn.com/b/ericlippert/archive/2009/11/12/closing-over-the-loop-variable-considered-harmful.aspx)
* [Eric Lippert: Closing over the loop variable, part two](http://blogs.msdn.com/b/ericlippert/archive/2009/11/16/closing-over-the-loop-variable-part-two.aspx)