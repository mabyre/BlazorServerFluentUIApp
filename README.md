## BlazorServer FluentUI App

An Application in Blazor C# using FluentUI thanks to Nuget

## Requirements

I started with:
- Visual Studio 2022 Community

## References

[Microsoft - FluentUI for Blazor](https://brave-cliff-0c0c93310.azurestaticapps.net/)

[ASP.NET C# - FluentUI for Balzor](https://asp-dotnet-csharp.sodevlog.com/2023/02/fluentui-for-blazor.html)

## Big Bug on FluentIcon

While trying to use : FluentAccordion with FluentIcon I add a stinks message :

> **Warning**
> An unhandled exception occurred while processing the request.
> ArgumentException: The requested icon (Globe, Size12, Regular) is not available in the collection
> Microsoft.Fast.Components.FluentUI.FluentIcon.OnParametersSet() in FluentIcon.cs, line 92

If I clicked on FluentIcon definition :

```csharp
    public static List<IconModel> LibraryUsedIcons = new()
    {
        new IconModel("ArrowSortUp", IconSize.Size20, IconVariant.Regular),
```

Using ArrowSortUp it works !

<img style="margin: 10px" src="Images/2023-03-06_13h25_02.png" alt="TemplateVisualStudio Ribbon transform Icon Image" />

## Trying to work on icons 

[Find the way to use BootStrap Icons for Blazor](https://github.com/windperson/BlazorBootstrapIconsdDemo)

Using BootStrap Icon for NavMenu

<img style="margin: 10px" src="Images/2023-03-07_16h45_00.png" alt="TemplateVisualStudio Ribbon transform Icon Image" />

## A Page for FluentHorizontalScroll

Don't work 

<img style="margin: 10px" src="Images/2023-03-07_16h49_04.png" alt="TemplateVisualStudio Ribbon transform Icon Image" />

## More work on FluentUI for Blazor

Obviously it's a little bit disapointing, some works some don't

<img style="margin: 10px" src="Images/2023-03-07_17h37_01.png" alt="TemplateVisualStudio Ribbon transform Icon Image" />





