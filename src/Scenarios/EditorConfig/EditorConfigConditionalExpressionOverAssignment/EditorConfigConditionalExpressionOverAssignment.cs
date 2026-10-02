namespace Testbed.EditorConfig.EditorConfigConditionalExpressionOverAssignment;

public class EditorConfigConditionalExpressionOverAssignment
{
    public static string Run()
    {
        string text;
        if (System.DateTime.MaxValue.Year > 1)
        {
            text = "a";
        }
        else
        {
            text = "b";
        }

        return text;
    }
}
