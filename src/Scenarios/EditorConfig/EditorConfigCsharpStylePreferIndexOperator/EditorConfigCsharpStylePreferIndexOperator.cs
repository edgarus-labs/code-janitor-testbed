namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferIndexOperator;

public class EditorConfigCsharpStylePreferIndexOperator
{
    public int Last(int[] values)
    {
        return values[values.Length - 1];
    }

    public static string Run() => new EditorConfigCsharpStylePreferIndexOperator().Last(new[] { 1, 2, 3 }).ToString();
}
