namespace Testbed.Settings.InsertBlankLinePaddingAfterMethods;

public class InsertBlankLinePaddingAfterMethods
{
    public int PadFirst { get; set; }
    public int Middle() { return 2; }
    public int PadLast { get; set; }

    public static string Run() => "ok";
}
