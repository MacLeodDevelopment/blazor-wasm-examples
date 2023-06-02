using System.Collections.Specialized;
using Blazor.Wasm.Examples.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.TransferService.ExampleConsumer;

/// <summary>
/// NB This component implements IDisposable - You MUST do this to
/// ensure that the events get unsubscribed from when the component is disposed
/// - OTHERWISE YOU'LL GET MEMORY LEAKS!
/// </summary>
public class ExampleConsumerComponent : ComponentBase, IDisposable
{
    [Inject] public ExampleTransferService? ExampleTransferService { get; set; }

    /// <summary>
    /// Methods which react to change events must have a signature which matches the corresponding event.
    ///
    /// i.e. If you want to react to the DataChanged event, which has EventHandler&lt;string&gt; you need to
    /// have a method with object? sender, string value as the method signature. 
    /// </summary>
    public void OnDataClassChanged(object? sender, string value)
    {
        InvokeAsync(StateHasChanged);
    }

    private void OnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        InvokeAsync(StateHasChanged);
    }

    /// <summary>
    /// Subscribe to the event in the initialize phase. 
    /// </summary>
    protected override void OnInitialized()
    {
        if (ExampleTransferService != null)
        {
            ExampleTransferService.ExampleInstances.CollectionChanged += OnCollectionChanged;
            ExampleTransferService.DataChanged += OnDataClassChanged;
        }
    }

    /// <summary>
    /// Ensure that the subscription is disposed of to avoid memory leaks. 
    /// </summary>
    public void Dispose()
    {
        if (ExampleTransferService != null)
        {
            ExampleTransferService.ExampleInstances.CollectionChanged -= OnCollectionChanged;
            ExampleTransferService.DataChanged -= OnDataClassChanged;
        }
    }
}