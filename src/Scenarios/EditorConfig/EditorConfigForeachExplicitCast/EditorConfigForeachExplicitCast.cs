namespace Testbed.EditorConfig.EditorConfigForeachExplicitCast;

public class EditorConfigForeachExplicitCast
{
    public static string Run()
    {
        var sum = 0;
        object[] items = { 1, 2 };
        foreach (int number in items)
        {
            sum += number;
        }

        return sum.ToString();
    }
}
