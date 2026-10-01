namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferSwitchExpression;

public class EditorConfigCsharpStylePreferSwitchExpression
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

    public static string Run() => new EditorConfigCsharpStylePreferSwitchExpression().Describe(2);
}
