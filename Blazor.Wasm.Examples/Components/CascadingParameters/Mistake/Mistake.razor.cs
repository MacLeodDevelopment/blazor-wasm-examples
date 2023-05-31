using Blazor.Wasm.Examples.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.CascadingParameters.Mistake;

public class MistakeComponent : ComponentBase
{
    [CascadingParameter(Name = "ComplexObjectFromParent")]
    public ComplexObject? ComplexObjectCascadedFromParent { get; set; }

    protected void Correct()
    {
        if (ComplexObjectCascadedFromParent != null)
        {
            ComplexObjectCascadedFromParent.Data = "Value changed correctly.";
        }
    }

    protected void Incorrect()
    {
        ComplexObjectCascadedFromParent = new ComplexObject
        {
            Data = "Reference changed - incorrect - as it will only update the object used in this component."
        };
    }
}