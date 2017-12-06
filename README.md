![Icon](https://resharper-plugins.jetbrains.com/Content/Images/packageReSharper.png)

# dotnet-Source.JetBrains.Annotations
> ReSharper Annotations help reduce false positive warnings, explicitly declare purity and nullability in your code, deal with implicit usages of members, support special semantics of APIs in ASP.NET and XAML frameworks and otherwise increase accuracy of ReSharper code inspections.

This package provides the actual source of [JetBrains.Annotations](https://www.nuget.org/packages/JetBrains.Annotations), as mentiond in https://blog.jetbrains.com/dotnet/2015/08/12/how-to-use-jetbrains-annotations-to-improve-resharper-inspections/ (*Including the source*).

**master** branch status
[![Build status](https://ci.appveyor.com/api/projects/status/y1uctwp46sibegt5?svg=true)](https://ci.appveyor.com/project/dittodhole/dotnet-source-jetbrains-annotations)

**develop** branch status
[![Build status](https://ci.appveyor.com/api/projects/status/y1uctwp46sibegt5/branch/develop?svg=true)](https://ci.appveyor.com/project/dittodhole/dotnet-source-jetbrains-annotations/branch/develop)

## Installing

### Releases

[![NuGet Status](https://img.shields.io/nuget/v/Source.JetBrains.Annotations.svg?style=flat-square)](https://www.nuget.org/packages/Source.JetBrains.Annotations)
https://www.nuget.org/packages/Source.JetBrains.Annotations

    PM> Install-Package Source.JetBrains.Annotations

### Pre Releases

    PM> nuget sources Add "dittodhole" https://www.myget.org/F/dittodhole/api/v3/index.json

[![MyGet Pre Release](https://img.shields.io/myget/dittodhole/vpre/Source.JetBrains.Annotations.svg?style=flat-square)](https://www.myget.org/feed/dittodhole/package/nuget/Source.JetBrains.Annotations)
https://www.myget.org/feed/dittodhole/package/nuget/Source.JetBrains.Annotations

    PM> Install-Package Source.JetBrains.Annotations -pre

## License

dotnet-Source.JetBrains.Annotations is published under [WTFNMFPLv3](https:////github.com/dittodhole/WTFNMFPLv3).
