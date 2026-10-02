namespace Testbed.Commands.SplitTopLevelTypes;

public class SplitTopLevelTypes
{
    public static string Run() => new SplitSecond().Name + SplitThird.Value;
}

public class SplitSecond
{
    public string Name => "second";
}

public static class SplitThird
{
    public const string Value = "third";
}
