using Blazor.Wasm.Examples.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.ParametersStateChanges.ChildWithEventCallback;

public class ChildWithEventCallbackComponent : ComponentBase
{
    [Parameter]
    public ComplexObject? ParameterFromParent { get; set; }
    
    /// <summary>
    /// The framework method StateHasChanged() can be passed from the parent as a delegate. 
    /// </summary>
    [Parameter]
    public EventCallback DelegateToCallWhenSomethingChanges { get; set; }

    protected async Task ModifyParameterFromChild()
    {
        await Task.Run(() =>
        {
            if (ParameterFromParent != null)
            {
                ParameterFromParent.Data = "This data is set in the CHILD, and updated by invoking the EventCallback";
                DelegateToCallWhenSomethingChanges.InvokeAsync();
            }
        });
    }
}