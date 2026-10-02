namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferIndexOperatorDisabled;

public class EditorConfigCsharpStylePreferIndexOperatorDisabled
{
    public int Last(int[] values)
    {
        return values[values.Length - 1];
    }

    public static string Run() => new EditorConfigCsharpStylePreferIndexOperatorDisabled().Last(new[] { 1, 2, 3 }).ToString();
}
