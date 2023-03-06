using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Microsoft.Fast.Components.FluentUI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorServerFluentUIApp.Pages;

public partial class PageFluentHorizontalScroll : ComponentBase
{
    [Inject]
    protected ILoggerFactory loggerFactory { get; set; }

    private ILogger<PageFluentHorizontalScroll> logger => loggerFactory.CreateLogger<PageFluentHorizontalScroll>();

    private void ExempleLog()
    { 
        logger.LogWarning("Someone has clicked me!");
    }

    private void OnHorizontalScrollStart(HorizontalScrollEventArgs args)
    {
        logger.LogInformation($"{args.Scroll}");
    }

    private void OnHorizontalScrollEnd(HorizontalScrollEventArgs args)
    {
        logger.LogInformation($"{args.Scroll}");
    }
}
