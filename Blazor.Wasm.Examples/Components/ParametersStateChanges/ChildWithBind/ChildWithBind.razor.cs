using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.ParametersStateChanges.ChildWithBind;

public class ChildWithBindComponent : ComponentBase
{
    [Parameter]
    public string? InputParameterFromParent { get; set; }

    /// <summary>
    /// To automatically bind to the parameter, the name of this method must be {ParameterName}Changed.
    /// </summary>
    [Parameter]
    public EventCallback<string?> InputParameterFromParentChanged { get; set; }

    protected async Task ModifyParameterFromChild()
    {
        await Task.Run(() =>
        {
            InputParameterFromParentChanged.InvokeAsync("This data is set in the CHILD, and bound using @bind");
        });
    }
}