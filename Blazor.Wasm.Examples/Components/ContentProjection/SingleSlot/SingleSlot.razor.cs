using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.ContentProjection.SingleSlot;

public class SingleSlotComponent : ComponentBase
{
    [Parameter] public RenderFragment? ChildContent { get; set; }
}