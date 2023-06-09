using System.Collections.ObjectModel;
using Blazor.Wasm.Examples.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Pages;

public partial class RenderOrder: IDisposable
{
    [Inject] public RenderOrderService RenderOrderService { get; set; } = null!; 

    protected override void OnInitialized()
    {
        base.OnInitialized();
        RenderOrderService.LogUpdated += OnLogUpdated;
    }

    private void OnLogUpdated(object? sender, IEnumerable<string> e)
    {
        InvokeAsync(StateHasChanged);
    }

    private void ClearState()
    {
        RenderOrderService.Clear();
    }

    public void Dispose()
    {
        RenderOrderService.LogUpdated -= OnLogUpdated;
    }
}
