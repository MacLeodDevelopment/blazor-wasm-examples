using Blazor.Wasm.Examples.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.ParametersStateChanges.ParametersStateChangeParent;

public class ParametersStateChangeParentComponent : ComponentBase
{
    public string? ParentSimpleParameter { get; set; } = "Default value set by the PARENT.";
    public string? AnotherParentSimpleParameter { get; set; } = "Another default value set by the PARENT.";

    public ComplexObject ComplexObjectInParent { get; set; } = new() { Data = "This value has been set by the PARENT." };

    protected async Task ModifyParameterFromParentAsync()
    {
        await Task.Run(() =>
        {
            ParentSimpleParameter = "This data is UPDATED by the PARENT";
        });
    }
}