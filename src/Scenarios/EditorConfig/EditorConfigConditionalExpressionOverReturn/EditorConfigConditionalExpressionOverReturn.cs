namespace Testbed.EditorConfig.EditorConfigConditionalExpressionOverReturn;

public class EditorConfigConditionalExpressionOverReturn
{
    private static string Pick(bool flag)
    {
        if (flag)
        {
            return "a";
        }
        else
        {
            return "b";
        }
    }

    public static string Run() => Pick(true);
}
