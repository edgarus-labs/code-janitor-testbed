namespace Testbed.Settings.InsertBlankLinePaddingBeforeEnumerations;

public class InsertBlankLinePaddingBeforeEnumerations
{
    public int PadFirst;
    public enum Kind { A, B }
    public int PadLast;

    public static string Run() => "ok";
}
