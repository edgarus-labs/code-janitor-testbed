namespace Testbed.Settings.InsertBlankLinePaddingAfterStructs;

public class InsertBlankLinePaddingAfterStructs
{
    public int PadFirst;
    public struct Pair { public int A; }
    public int PadLast;

    public static string Run() => "ok";
}
