namespace Testbed.EditorConfig.EditorConfigDotnetStylePreferCompoundAssignment;

public class EditorConfigDotnetStylePreferCompoundAssignment
{
    private int _count;

    public void Grow(int step)
    {
        _count = _count + step;
    }

    public static string Run()
    {
        var instance = new EditorConfigDotnetStylePreferCompoundAssignment();
        instance.Grow(3);

        return instance._count.ToString();
    }
}
