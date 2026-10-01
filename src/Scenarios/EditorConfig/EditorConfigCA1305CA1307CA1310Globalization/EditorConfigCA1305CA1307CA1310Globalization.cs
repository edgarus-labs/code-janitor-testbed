namespace Testbed.EditorConfig.EditorConfigCA1305CA1307CA1310Globalization;

public class EditorConfigCA1305CA1307CA1310Globalization
{
    public static string Run()
    {
        var number = 1.5.ToString();
        var formatted = string.Format("{0}", 2);
        var index = "abc".IndexOf("b");
        var compared = string.Compare("a", "b");
        var starts = "abc".StartsWith("a");

        return number + formatted + index + compared + starts;
    }
}
