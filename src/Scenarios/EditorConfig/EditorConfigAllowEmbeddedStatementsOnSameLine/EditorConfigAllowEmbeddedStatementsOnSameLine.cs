namespace Testbed.EditorConfig.EditorConfigAllowEmbeddedStatementsOnSameLine;

public class EditorConfigAllowEmbeddedStatementsOnSameLine
{
    public static string Run()
    {
        var value = 1;
        if (value > 0) value++;

        return value.ToString();
    }
}
