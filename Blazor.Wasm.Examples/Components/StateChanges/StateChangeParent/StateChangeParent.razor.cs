using Blazor.Wasm.Examples.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.StateChanges.StateChangeParent;

public class StateChangeParentComponent : ComponentBase
{
    public ComplexObject? ParentComplexObject { get; set; }

    protected override Task OnInitializedAsync()
    {
        ParentComplexObject = new ComplexObject
        {
            Data = "This data is set in the State Change Parent component"
        };

        return base.OnInitializedAsync();
    }

    /// <summary>
    /// This method is invoked by the child component. So that changes in the child will
    /// trigger the state update in the parent. 
    /// The instance of this component is passed to the child as a cascading parameter. 
    /// </summary>
    public async Task NotifyChangeAsync()
    {
        await InvokeAsync(StateHasChanged);
    }

    protected async Task ModifyCascadingParameterFromParentAsync()
    {
        await Task.Run(() =>
        {
            if (ParentComplexObject != null)
            {
                ParentComplexObject.Data = "This data is UPDATED by the PARENT";
            }
        });
    }
}