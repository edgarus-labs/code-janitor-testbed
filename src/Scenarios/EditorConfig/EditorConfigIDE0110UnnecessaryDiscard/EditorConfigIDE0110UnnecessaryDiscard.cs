namespace Testbed.EditorConfig.EditorConfigIDE0110UnnecessaryDiscard;

public class EditorConfigIDE0110UnnecessaryDiscard
{
    private static string Kind(object value)
    {
        switch (value)
        {
            case string _:
                return "text";
            default:
                return "other";
        }
    }

    public static string Run() => Kind("a");
}
