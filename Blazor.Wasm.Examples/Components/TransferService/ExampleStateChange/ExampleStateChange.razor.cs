using Blazor.Wasm.Examples.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.TransferService.ExampleStateChange;

public class ExampleStateChangeComponent : ComponentBase
{
    [Inject] public ExampleTransferService? ExampleTransferService { get; set; }

    /*
     * IMPORTANT!
     * NB: Interesting to note that the binding won't update the field in this component when
     * a change is made in the Example Consumer Component, even though that component updates
     * the state.
     *
     * The reason for this is because this component does not know anything about the update.
     * So, we have to set up the subscription to the event change in the same way and invoke
     * StateHasChanged.
     * i.e.
     *
     *      public void OnDataClassChanged(object? sender, string value)
     *      {
     *          InvokeAsync(StateHasChanged);
     *      }
     *
     *      protected override void OnInitialized()
     *      {
     *          ExampleTransferService.DataChanged += OnDataClassChanged;
     *      }
     */

    public void AddSomethingToSharedState()
    {
        ExampleTransferService?.ExampleInstances.Add(new()
        {
            Data = $"New instance {DateTime.Now}"
        });
    }
}