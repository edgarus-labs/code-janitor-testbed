namespace Testbed.EditorConfig.EditorConfigCsharpStylePatternMatchingOverIsWithCastCheck;

public class EditorConfigCsharpStylePatternMatchingOverIsWithCastCheck
{
    public string Cast(object value)
    {
        if (value is string)
        {
            var text = (string)value;

            return text.ToUpperInvariant();
        }

        return "";
    }

    public static string Run() => new EditorConfigCsharpStylePatternMatchingOverIsWithCastCheck().Cast("abc");
}
