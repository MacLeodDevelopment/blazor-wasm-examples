using Blazor.Wasm.Examples.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.CascadingParameters.Parent
{
    public class ParentComponent : ComponentBase
    {
        public string ParentData { get; set; } = "Data from Parent Component";

        public ComplexObject? ParentComplexObject { get; set; }

        protected override Task OnInitializedAsync()
        {
            ParentComplexObject = new ComplexObject
            {
                Data = "This data is set in the OnInitializedAsync method of the PARENT component."
            };

            return base.OnInitializedAsync();
        }
    }
}
