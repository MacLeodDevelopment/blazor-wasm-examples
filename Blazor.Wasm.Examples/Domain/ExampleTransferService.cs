using System.Collections.ObjectModel;

namespace Blazor.Wasm.Examples.Domain;

/// <summary>
/// Service is registered in the IoC container: builder.Services.AddScoped&lt;ExampleTransferService&gt;();
/// </summary>
public class ExampleTransferService
{
    private string _data = "Some Default Data";
    
    /// <summary>
    /// Demonstrates a property being used to hold state and be consumed by components.
    /// </summary>
    public string Data
    {
        get => _data;
        set
        {
            _data = value;
            DataChanged.Invoke(this, value);
        }
    }

    /// <summary>
    /// Example of a collection being used to store state.
    /// A better pattern here would be to have a set method and make this readonly?
    ///
    /// You can either use ObservableCollection or your own Collection&lt;T&gt; class
    /// </summary>
    public ObservableCollection<ComplexObject> ExampleInstances { get; set; } = new();

    /// <summary>
    /// This event handler is invoked in the setter of Data - so whenever something changes Data,
    /// it invokes any registered callbacks.
    /// The callbacks must have the same signature (object sender, string value), but this can be anything.
    /// Also, this could be invoked when a method is called (rather than in the setter of a property). 
    /// </summary>
    public event EventHandler<string> DataChanged = (sender, value) => { };
}