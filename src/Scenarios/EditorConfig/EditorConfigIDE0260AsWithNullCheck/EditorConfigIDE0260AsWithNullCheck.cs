namespace Testbed.EditorConfig.EditorConfigIDE0260AsWithNullCheck;

public class EditorConfigIDE0260AsWithNullCheck
{
    public static string Run()
    {
        object value = "a";
        bool matched = (value as string)?.Length > 0;

        return matched.ToString();
    }
}
