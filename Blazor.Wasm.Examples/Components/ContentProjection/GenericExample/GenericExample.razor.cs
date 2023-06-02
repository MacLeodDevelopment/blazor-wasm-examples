using Blazor.Wasm.Examples.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.ContentProjection.GenericExample;

public class GenericExampleComponent : ComponentBase
{
    [Parameter]
    public RenderFragment<Cat>? CatTemplate { get; set; }

    [Parameter]
    public RenderFragment<Dog>? DogTemplate { get; set; }

    [Parameter]
    public RenderFragment<Bird>? BirdTemplate { get; set; }

    [Parameter]
    public List<IAnimal> InputData { get; set; } = new();
}