## Description

The code uses undocumented C# keywords like __makeref, __refvalue. MS.NET supports these keyword. Mono 3 also supports, but does it differently. Mono 2 doesn't support.

## Runs

* **ms** (Windows, MS.NET): Works correctly
* **mono-3** (Linux, Mono 3.10.0): Unhandled Exception
* **mono-2** (Linux, Mono 2.4.4): Compilation failed

## Links

* [CodeProject: UnCommon C# keywords - A Look](http://www.codeproject.com/Articles/38695/UnCommon-C-keywords-A-Look)
* [CodeProject: Pointers UNDOCUMENTED](http://www.codeproject.com/Articles/4046/Pointers-UNDOCUMENTED)
* [StackOverflow: Why is TypedReference behind the scenes? It's so fast and safe… almost magical!](http://stackoverflow.com/questions/4764573/why-is-typedreference-behind-the-scenes-its-so-fast-and-safe-almost-magical)