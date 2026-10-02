namespace Testbed.EditorConfig.EditorConfigCA2249ContainsInsteadOfIndexOf;

public class EditorConfigCA2249ContainsInsteadOfIndexOf
{
    public static string Run()
    {
        var text = "abc";

        return (text.IndexOf("b") >= 0).ToString();
    }
}
