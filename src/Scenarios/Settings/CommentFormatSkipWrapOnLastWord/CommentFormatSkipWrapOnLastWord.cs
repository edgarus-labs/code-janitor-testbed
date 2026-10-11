namespace Testbed.Settings.CommentFormatSkipWrapOnLastWord;

public class CommentFormatSkipWrapOnLastWord
{
    public static string Run()
    {
        // This comment is exactly long enough that only its very last word crosses the wrap column: overflow
        return "last word";
    }
}
