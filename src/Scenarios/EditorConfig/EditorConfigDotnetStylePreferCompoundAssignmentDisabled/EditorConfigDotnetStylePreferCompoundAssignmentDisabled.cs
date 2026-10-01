namespace Testbed.EditorConfig.EditorConfigDotnetStylePreferCompoundAssignmentDisabled;

public class EditorConfigDotnetStylePreferCompoundAssignmentDisabled
{
    private int _count;

    public void Grow(int step)
    {
        _count = _count + step;
    }

    public static string Run()
    {
        var instance = new EditorConfigDotnetStylePreferCompoundAssignmentDisabled();
        instance.Grow(3);

        return instance._count.ToString();
    }
}
