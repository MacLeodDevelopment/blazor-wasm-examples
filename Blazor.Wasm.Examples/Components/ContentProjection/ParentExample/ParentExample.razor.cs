using Blazor.Wasm.Examples.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Wasm.Examples.Components.ContentProjection.ParentExample;

public class ParentExampleComponent : ComponentBase
{
    public List<IAnimal> Animals { get; set; } = new()
    {
        new Dog() { Name = "Doggy" },
        new Cat() { Name = "Bagpuss" },
        new Bird() { Name = "Birdie" },
        new Cat() { Name = "Kitty" },
        new Dog() { Name = "Fido" },
    };
}