namespace Testbed.Settings.RemoveBlankLinesBetweenChainedStatements;

public class RemoveBlankLinesBetweenChainedStatements
{
    public static string Run()
    {
        var text = "";
        if (text.Length > 0)
        {
            text = "a";
        }

        else
        {
            text = "b";
        }

        try
        {
            text += "c";
        }

        finally
        {
            text += "d";
        }

        return text;
    }
}
