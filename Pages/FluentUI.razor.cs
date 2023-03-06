using Microsoft.AspNetCore.Components;
using Microsoft.Fast.Components.FluentUI.DesignTokens;
using Microsoft.Fast.Components.FluentUI;

namespace BlazorServerFluentUIApp.Pages;

public partial class FluentUI : ComponentBase
{
#region Accordion

    string activeId = "accordion-1";

    FluentAccordionItem? changed;

    private void HandleOnAccordionItemChange(FluentAccordionItem item)
    {
        changed = item;
    }

#endregion

    private int currentCount = 0;

    private void WasClicked()
    {
        currentCount++;
    }

    [Inject]
    protected BaseLayerLuminance BaseLayerLuminance { get; set; } = default!;

    [Inject]
    private AccentBaseColor AccentBaseColor { get; set; } = default!;

    [Inject]
    private BodyFont BodyFont { get; set; } = default!;

    [Inject]
    private StrokeWidth StrokeWidth { get; set; } = default!;

    [Inject]
    private ControlCornerRadius ControlCornerRadius { get; set; } = default!;

    private FluentButton? ref1;
    private FluentButton? ref2;
    private FluentButton? ref3;
    private FluentButton? ref4;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            //Set to dark mode
            await BaseLayerLuminance.SetValueFor(ref1!.Element, (float)0.15);

            //Set to Excel color
            await AccentBaseColor.SetValueFor(ref2!.Element, "#185ABD".ToSwatch());

            //Set the font
            await BodyFont.SetValueFor(ref3!.Element, "Comic Sans MS");

            //Set 'border' width for ref4
            await StrokeWidth.SetValueFor(ref4!.Element, 7);

            //And change conrner radius as well
            await ControlCornerRadius.SetValueFor(ref4!.Element, 15);

            StateHasChanged();
        }
    }

    public async Task OnClick()
    {
        // Remove the wide border
        await StrokeWidth.DeleteValueFor(ref4!.Element);

        currentCount++;
    }
}
