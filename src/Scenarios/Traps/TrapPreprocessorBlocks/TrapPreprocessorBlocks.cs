namespace Testbed.Traps.TrapPreprocessorBlocks;

public class TrapPreprocessorBlocks
{
    public static string Run()
    {
        var text = "a";
#if DEBUG
        text += "debug";
#else
        text += "release";
#endif
#region Notes
        text += "!";
#endregion
        return text;
    }
}
