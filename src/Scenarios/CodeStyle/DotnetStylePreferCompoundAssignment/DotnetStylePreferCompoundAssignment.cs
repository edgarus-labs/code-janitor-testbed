namespace Testbed.CodeStyle.DotnetStylePreferCompoundAssignment;

public class DotnetStylePreferCompoundAssignment
{
    private int _count;

    public void Grow(int step)
    {
        _count = _count + step;
    }

    public static string Run()
    {
        var instance = new DotnetStylePreferCompoundAssignment();
        instance.Grow(3);

        return instance._count.ToString();
    }
}
