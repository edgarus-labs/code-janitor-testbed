namespace Testbed.EditorConfig.EditorConfigCA1822MakeMemberStatic;

internal class Helper
{
    internal int DoubleOf(int value) => value * 2;
}

public class EditorConfigCA1822MakeMemberStatic
{
    public static string Run() => new Helper().GetType().Name;
}
