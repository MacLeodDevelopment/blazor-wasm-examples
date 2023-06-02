using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.ContentProjection.MultiSlot;

public class MultiSlotComponent : ComponentBase
{
    [Parameter] public RenderFragment? Slot1 { get; set; }
    [Parameter] public RenderFragment? Slot2 { get; set; }

    /// <summary>
    /// Example of no content supplied.
    /// </summary>
    [Parameter] public RenderFragment? Slot3 { get; set; }

    [Parameter]
    public List<string> ParametersToPassDown { get; set; } = new();
}