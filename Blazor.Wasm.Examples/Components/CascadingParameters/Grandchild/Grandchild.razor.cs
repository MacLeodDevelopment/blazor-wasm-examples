using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.CascadingParameters.Grandchild;

public class GrandchildComponent : ComponentBase
{
    [CascadingParameter(Name = "DataFromParent")]
    public string DataCascadedFromGrandparent { get; set; } = "";
}