namespace Testbed.EditorConfig.EditorConfigCA1862OrdinalIgnoreCase;

public class EditorConfigCA1862OrdinalIgnoreCase
{
    public static string Run()
    {
        var text = "abc";

        return (text.ToUpperInvariant() == "ABC").ToString();
    }
}
