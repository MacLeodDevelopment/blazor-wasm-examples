using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.Parameters.ParameterChild;

public class ParameterChildComponent : ComponentBase
{
    [Parameter]
    public string OptionalInputParameter { get; set; } = "Default Value set in the Child";

    /// <summary>
    /// The EditorRequired attribute results in a compiler warning if a value is not supplied. 
    /// </summary>
    [EditorRequired]
    [Parameter]
    public string? RequiredInputParameter { get; set; }

    /// <summary>
    /// This dictionary will capture all the attributes passed from the parent component.
    /// Values can then be accessed by key, e.g. AnyCustomHtml5Attribute
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> AdditionalAttributes { get; set; } = new();
}