namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferSwitchExpressionDisabled;

public class EditorConfigCsharpStylePreferSwitchExpressionDisabled
{
    public string Describe(int value)
    {
        switch (value)
        {
            case 1:
                return "one";
            case 2:
                return "two";
            default:
                return "many";
        }
    }

    public static string Run() => new EditorConfigCsharpStylePreferSwitchExpressionDisabled().Describe(2);
}
