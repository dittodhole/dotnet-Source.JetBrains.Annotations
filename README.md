![](assets/ReSharper_64.png)

# dotnet-Source.JetBrains.Annotations

> ReSharper Annotations help reduce false positive warnings, explicitly declare purity and nullability in your code, deal with implicit usages of members, support special semantics of APIs in ASP.NET and XAML frameworks and otherwise increase accuracy of ReSharper code inspections.

This package provides the actual source of [JetBrains.Annotations](https://www.nuget.org/packages/JetBrains.Annotations), as mentiond in https://blog.jetbrains.com/dotnet/2015/08/12/how-to-use-jetbrains-annotations-to-improve-resharper-inspections/ (*Including the source*).

## Build status

[![](https://img.shields.io/appveyor/ci/dittodhole/dotnet-source-jetbrains-annotations.svg)](https://ci.appveyor.com/project/dittodhole/dotnet-source-jetbrains-annotations)

## Installing

### myget.org

[![](https://img.shields.io/myget/dittodhole/vpre/Source.JetBrains.Annotations.svg)](https://www.myget.org/feed/dittodhole/package/nuget/Source.JetBrains.Annotations)

```powershell
PM> Install-Package -Id Source.JetBrains.Annotations -pre --source https://www.myget.org/F/dittodhole/api/v2
```

### nuget.org

[![](https://img.shields.io/nuget/v/Source.JetBrains.Annotations.svg)](https://www.nuget.org/packages/Source.JetBrains.Annotations)

```powershell
PM> Install-Package -Id Source.JetBrains.Annotations
```

## Developing & Building

```cmd
> git clone https://github.com/dittodhole/dotnet-Source.JetBrains.Annotations.git
> cd dotnet-Source.JetBrains.Annotations
dotnet-Source.JetBrains.Annotations> cd build
dotnet-Source.JetBrains.Annotations/build> build.bat
```

This will create the following artifacts:

- `artifacts/Source.JetBrains.Annotations.{version}.nupkg`

## License

dotnet-Source.JetBrains.Annotations is published under [WTFNMFPLv3](https://github.com/dittodhole/WTFNMFPLv3).

## Icon

[ReSharper](https://resources.jetbrains.com/storage/products/resharper/img/meta/ReSharper_64.png) by [JetBrains](https://www.jetbrains.com/resharper/).
