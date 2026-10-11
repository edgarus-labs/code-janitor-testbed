namespace Testbed.Settings.CommentFormatIgnoreLinesStartingWith;

public class CommentFormatIgnoreLinesStartingWith
{
    public static string Run()
    {
        // KEEP this line exactly as it is, even though it is far too long for the wrap column.
        //
        // This other comment is far too long for a wrap column of forty characters.
        return "ignored";
    }
}
