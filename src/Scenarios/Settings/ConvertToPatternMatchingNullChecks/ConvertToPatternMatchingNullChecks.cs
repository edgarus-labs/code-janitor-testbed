namespace Testbed.Settings.ConvertToPatternMatchingNullChecks;

public class ConvertToPatternMatchingNullChecks
{
    public static string Run() => Check(null) + Check("x");

    private static string Check(string? text)
    {
        if (text == null)
        {
            return "none";
        }

        return text != null ? text : "";
    }
}
