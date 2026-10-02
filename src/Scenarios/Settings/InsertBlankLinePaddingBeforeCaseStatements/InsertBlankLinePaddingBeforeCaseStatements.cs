namespace Testbed.Settings.InsertBlankLinePaddingBeforeCaseStatements;

public class InsertBlankLinePaddingBeforeCaseStatements
{
    public static string Run()
    {
        var text = "";
        switch (text.Length)
        {
            case 0:
                text = "a";
                break;
            case 1:
                text = "b";
                break;
            default:
                break;
        }

        return text;
    }
}
