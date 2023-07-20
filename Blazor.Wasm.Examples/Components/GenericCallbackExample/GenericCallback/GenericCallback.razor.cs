using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.GenericCallbackExample.GenericCallback;

public class GenericCallbackComponent : ComponentBase
{
    [CascadingParameter(Name = "ExpectsAComponentImplementingThisInterface")]
    public IExpectAComponentImplementingThisInterfaceFromMyLibrary? Parent { get; set; }

    protected async Task InvokeCallbackAsync()
    {
        var someDataToSendToTheConsumingApplication = new SomeTypeFromMyLibrary
        {
            Data = "This is some data from the component in the component library."
        };

        await Parent.DoSomeStuffAsync(someDataToSendToTheConsumingApplication);
    }
}

/// <summary>
/// This would live in the component library.
/// </summary>
public interface IExpectAComponentImplementingThisInterfaceFromMyLibrary
{
    Task DoSomeStuffAsync(SomeTypeFromMyLibrary someTypeFromMyLibrary);
}

/// <summary>
/// This would live in the component library - could be an interface, then the consumer
/// would just create a type that implements it. 
/// </summary>
public class SomeTypeFromMyLibrary
{
    public string? Data { get; set; }
}