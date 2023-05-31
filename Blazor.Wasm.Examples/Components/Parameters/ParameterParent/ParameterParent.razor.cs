using Blazor.Wasm.Examples.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.Parameters.ParameterParent;

public class ParameterParentComponent : ComponentBase
{
    public ComplexObject? ParentComplexObject { get; set; }

    protected override Task OnInitializedAsync()
    {
        ParentComplexObject = new ComplexObject
        {
            Data = "This data is set in the OnInitializedAsync method of the PARAMETER PARENT component."
        };

        return base.OnInitializedAsync();
    }
}