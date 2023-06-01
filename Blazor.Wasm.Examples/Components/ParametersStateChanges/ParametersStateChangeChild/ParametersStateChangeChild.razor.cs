using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.ParametersStateChanges.ParametersStateChangeChild;

public class ParametersStateChangeChildComponent : ComponentBase
{
    [Parameter]
    public string? SimpleParameterFromParent { get; set; }
}