using Blazor.Wasm.Examples.Components.StateChanges.StateChangeParent;
using Blazor.Wasm.Examples.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.StateChanges.StateChangeChild;

public class StateChangeChildComponent : ComponentBase
{
    [CascadingParameter(Name = "ComplexObjectFromParent")]
    public ComplexObject? DataCascadedFromParent { get; set; }

    [CascadingParameter(Name = "ParentComponent")]
    public StateChangeParentComponent? Parent { get; set; }

    protected async Task ModifyCascadingParameterFromChildAsync()
    {
        if (Parent != null && DataCascadedFromParent != null)
        {
            DataCascadedFromParent.Data = "This data is UPDATED by the CHILD";
            await Parent.NotifyChangeAsync();
        }
    }
}