using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.CascadingParameters.Child;

public class ChildComponent : ComponentBase
{
    [CascadingParameter(Name = "DataFromParent")]
    public string DataCascadedFromParent { get; set; } = "";
}