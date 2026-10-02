namespace Testbed.Settings.InsertBlankLinePaddingAfterPropertiesMultiLine;

public class InsertBlankLinePaddingAfterPropertiesMultiLine
{
    public void PadFirst() { }
    public int Multi
    {
        get { return 1; }
        set { }
    }
    public void PadLast() { }

    public static string Run() => "ok";
}
