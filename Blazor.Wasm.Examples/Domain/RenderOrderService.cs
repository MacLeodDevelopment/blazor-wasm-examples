using System.Collections.ObjectModel;

namespace Blazor.Wasm.Examples.Domain;

public class RenderOrderService
{
    private readonly List<string> _log;
    
    public IEnumerable<string> Log => _log;

    public RenderOrderService()
    {
        _log = new List<string>();
    }

    public void AddToLog(string message)
    {
        _log.Add(message);
        LogUpdated.Invoke(this, _log);
    }
    
    public event EventHandler<IEnumerable<string>> LogUpdated = (sender, value) => { };

    public void Clear()
    {
        _log.Clear();
        LogUpdated.Invoke(this, _log);
    }
}