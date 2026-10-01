namespace Testbed.EditorConfig.EditorConfigCsharpPreferBracesWhenMultiline;

public class EditorConfigCsharpPreferBracesWhenMultiline
{
    public static string Run()
    {
        var text = "";
        if (text.Length == 0)
            text = "single";
        if (text.Length > 0)
            text +=
                "multi";

        return text;
    }
}
