using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.CascadingParameters.Sibling
{
    public class SiblingComponent : ComponentBase
    {
        [CascadingParameter(Name = "DataFromParent")]
        public string DataCascadedFromParent { get; set; } = "";
    }
}
