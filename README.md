# Tooling.Net.AssemblyFinder

Use a light and usefull assembly finder on your application.
It supports IOC components (Interface <> Concrete classe)
 
=========

## Build 

[![Build status](https://ci.appveyor.com/api/projects/status/01yde5h69kb3snj9?svg=true)](https://ci.appveyor.com/project/mathieumack/tooling-net-assemblyfinder)

## Nuget

[![NuGet package](https://buildstats.info/nuget/Tooling.Net.AssemblyFinder)](https://nuget.org/packages/Tooling.Net.AssemblyFinder)

## Platform Support

| Platform | Available 
| --- | --- |
| WPF 4.5 | &#x2713; | 
| UWP | &#x2713; | 
| Xamarin.Android | &#x2713; |
| Xamarin.iOS | &#x2713; |

### Core

The Core library contains only the interface of the Assembly finder.
The goal is to allow you to register the AssemblyFinder by an IOC in your application.
For example with mvvmcross (https://www.mvvmcross.com/) you can register the Assembly finder on the IOC :
```C#
    Mvx.RegisterSingleton<IAssemblyfinder>(new Assemblyfinder());
```

## Support
If you have any questions, problems or suggestions, create an issue.