namespace Testbed.EditorConfig.EditorConfigIDE0080UnnecessarySuppressionOperator;

public class EditorConfigIDE0080UnnecessarySuppressionOperator
{
    public static string Run()
    {
        object value = "a";
        bool isText = value !is string;

        return isText.ToString();
    }
}
