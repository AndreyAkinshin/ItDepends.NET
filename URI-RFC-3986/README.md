## Description

The code:

```cs
var uri = new Uri("http://localhost/%2F1");
Console.WriteLine(uri.OriginalString);
Console.WriteLine(uri.AbsoluteUri);
```

## Runs

* **ms-4.0** (Windows, MS.NET 4.0):
```
http://localhost/%2F1
http://localhost//1
```

* **ms-4.5** (Windows, MS.NET 4.5):
```
http://localhost/%2F1
http://localhost/%2F1
```

* **mono-3.10.0** (Linux, Mono 3.10.0, `mono Program.exe`):
```
http://localhost/%2F1
http://localhost/%2F1
```

* **mono-3.10.0-flag** (Linux, Mono 3.10.0, `MONO_URI_IRIPARSING=false mono Program.exe`):
```
http://localhost/%2F1
http://localhost//1
```

## Links

* [MS Connect 511010: Erroneous URI parsing for encoded, reserved characters, according to RFC 3986](https://connect.microsoft.com/VisualStudio/feedback/details/511010/erroneous-uri-parsing-for-encoded-reserved-characters-according-to-rfc-3986)
* [Mono Bug 16960](https://bugzilla.xamarin.com/show_bug.cgi?id=16960)
* [StackOverflow: Getting a Uri with escaped slashes on mono](http://stackoverflow.com/q/20769150/184842)
* [StackOverflow: GETting a URL with an url-encoded slash](http://stackoverflow.com/q/781205/184842)
* [Mono 3.10.0 release notes](http://www.mono-project.com/docs/about-mono/releases/3.10.0/)
* [Mike Hadlow: How to stop System.Uri un-escaping forward slash characters](http://mikehadlow.blogspot.co.uk/2011/08/how-to-stop-systemuri-un-escaping.html)
* [Arnout's Eclectica: URL-encoded slashes in System.Uri](http://grootveld.com/archives/21/url-encoded-slashes-in-systemuri)
* [Andrey Akinshin: About slash escaping in .NET (In Russian)](http://aakinshin.blogspot.co.il/2014/11/dotnet-uri-slash-escape.html)