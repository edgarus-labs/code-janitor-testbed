namespace Testbed.EditorConfig.EditorConfigAllowBlankLinesBetweenConsecutiveBraces;

public class EditorConfigAllowBlankLinesBetweenConsecutiveBraces
{
    public static string Run()
    {
        if (System.DateTime.MaxValue.Year > 1)
        {
            if (System.DateTime.MaxValue.Year > 2)
            {
                return "a";
            }

        }

        return "b";
    }
}
