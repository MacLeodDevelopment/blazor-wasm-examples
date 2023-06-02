namespace Blazor.Wasm.Examples.Domain;

public interface IAnimal
{
    string? Name { get; set; }
}

public class Bird : IAnimal
{
    public string? Name { get; set; }
}

public class Cat : IAnimal
{
    public string? Name { get; set; }
}

public class Dog : IAnimal
{
    public string? Name { get; set; }
}