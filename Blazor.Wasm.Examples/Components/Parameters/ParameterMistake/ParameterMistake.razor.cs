using Blazor.Wasm.Examples.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.Parameters.ParameterMistake;

public class ParameterMistakeComponent : ComponentBase
{
    [Parameter]
    public ComplexObject? ComplexObjectPassedFromParent { get; set; } = new();

    public void Correct()
    {
        if (ComplexObjectPassedFromParent != null)
        {
            ComplexObjectPassedFromParent.Data = "Value changed correctly by the Child";
        }
    }

    public void Incorrect()
    {
        ComplexObjectPassedFromParent = new()
        {
            Data = "Reference changed by the child - this is a mistake!"
        };
    }
}