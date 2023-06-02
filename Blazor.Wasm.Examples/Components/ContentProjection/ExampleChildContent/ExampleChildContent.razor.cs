using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.ContentProjection.ExampleChildContent;

public class ExampleChildContentComponent : ComponentBase
{
    [Parameter] public string? ProjectedParameter { get; set; }
}