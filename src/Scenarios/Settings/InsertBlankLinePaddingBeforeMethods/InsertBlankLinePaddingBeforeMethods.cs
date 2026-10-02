namespace Testbed.Settings.InsertBlankLinePaddingBeforeMethods;

public class InsertBlankLinePaddingBeforeMethods
{
    public int PadFirst { get; set; }
    public int Middle() { return 2; }
    public int PadLast { get; set; }

    public static string Run() => "ok";
}
