using Blazor.Wasm.Examples.Components.GenericCallbackExample.GenericCallback;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.GenericCallbackExample.WrapperInConsumingApp;

public class WrapperInConsumingAppComponent : ComponentBase, IExpectAComponentImplementingThisInterfaceFromMyLibrary
{
    protected string? SomeDataSentBackToMe { get; set; }

    public async Task DoSomeStuffAsync(SomeTypeFromMyLibrary someTypeFromMyLibrary)
    {
        SomeDataSentBackToMe = someTypeFromMyLibrary.Data;
        await InvokeAsync(StateHasChanged);
    }
}