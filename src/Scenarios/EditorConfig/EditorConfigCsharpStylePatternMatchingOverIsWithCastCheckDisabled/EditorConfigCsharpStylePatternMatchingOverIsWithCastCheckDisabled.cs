namespace Testbed.EditorConfig.EditorConfigCsharpStylePatternMatchingOverIsWithCastCheckDisabled;

public class EditorConfigCsharpStylePatternMatchingOverIsWithCastCheckDisabled
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

    public static string Run() => new EditorConfigCsharpStylePatternMatchingOverIsWithCastCheckDisabled().Cast("abc");
}
