namespace Testbed.Settings.InsertBlankLinePaddingAfterEnumerations;

public class InsertBlankLinePaddingAfterEnumerations
{
    public int PadFirst;
    public enum Kind { A, B }
    public int PadLast;

    public static string Run() => "ok";
}
