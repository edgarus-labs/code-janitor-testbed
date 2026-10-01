namespace Testbed.EditorConfig.EditorConfigPreferSystemThreadingLock;

public class EditorConfigPreferSystemThreadingLock
{
    private readonly object _gate = new();
    private int _value;

    public void Add()
    {
        lock (_gate)
        {
            _value++;
        }
    }

    public static string Run()
    {
        var instance = new EditorConfigPreferSystemThreadingLock();
        instance.Add();

        return instance._value.ToString();
    }
}
