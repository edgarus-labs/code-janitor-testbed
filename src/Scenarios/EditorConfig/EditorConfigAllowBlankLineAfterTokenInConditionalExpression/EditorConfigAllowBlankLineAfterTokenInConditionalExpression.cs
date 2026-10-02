namespace Testbed.EditorConfig.EditorConfigAllowBlankLineAfterTokenInConditionalExpression;

public class EditorConfigAllowBlankLineAfterTokenInConditionalExpression
{
    public static string Run()
    {
        var value = System.DateTime.MaxValue.Year > 1 ?

            "a" :

            "b";

        return value;
    }
}
