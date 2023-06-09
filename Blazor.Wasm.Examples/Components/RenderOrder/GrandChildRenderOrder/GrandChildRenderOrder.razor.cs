using System.Globalization;
using Blazor.Wasm.Examples.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.RenderOrder.GrandChildRenderOrder;

public class GrandChildRenderOrderComponent : ComponentBase
{
    [Inject] public RenderOrderService? RenderOrderService { get; set; }
    [Parameter] public string Name { get; set; }

    protected override void OnInitialized()
    {
        RenderOrderService?.AddToLog(
            $"{Name} Render Order Component **On Initialized** at: {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}");
    }

    protected override async Task OnInitializedAsync()
    {
        await Task.Run(() =>
        {
            RenderOrderService?.AddToLog(
                $"{Name} Render Order Component **On Initialized Async ** at: {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}");
        });
    }
}