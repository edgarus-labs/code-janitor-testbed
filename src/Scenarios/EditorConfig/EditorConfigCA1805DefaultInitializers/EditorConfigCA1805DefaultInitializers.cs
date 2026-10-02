namespace Testbed.EditorConfig.EditorConfigCA1805DefaultInitializers;

public class EditorConfigCA1805DefaultInitializers
{
    private int _count = 0;
    private string? _name = null;

    public void Add()
    {
        _count++;
        _name = "x";
    }

    public static string Run()
    {
        var instance = new EditorConfigCA1805DefaultInitializers();
        instance.Add();

        return instance._count + (instance._name ?? "");
    }
}
