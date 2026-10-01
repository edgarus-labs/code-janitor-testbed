namespace Testbed.EditorConfig.EditorConfigIDE0050AnonymousTypeToTuple;

public class EditorConfigIDE0050AnonymousTypeToTuple
{
    public static string Run()
    {
        var pair = new { First = 1, Second = 2 };

        return (pair.First + pair.Second).ToString();
    }
}
