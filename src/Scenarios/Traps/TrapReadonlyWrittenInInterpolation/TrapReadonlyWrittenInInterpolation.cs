namespace Testbed.Traps.TrapReadonlyWrittenInInterpolation;

using System.Threading;

public class TrapReadonlyWrittenInInterpolation
{
    private int _counter;
    private int _stepped;
    private int _assigned;
    private int _parsed;

    public string Next() => $"id-{Interlocked.Increment(ref _counter)}";

    public string Step() => $"{_stepped++}/{--_stepped}";

    public string Assign() => $"{(_assigned = 3)} {(_assigned += 2)}";

    public string Parse(string text) => $"{int.TryParse(text, out _parsed)}:{_parsed}";

    public static string Run()
    {
        var instance = new TrapReadonlyWrittenInInterpolation();

        return instance.Next() + instance.Step() + instance.Assign() + instance.Parse("7");
    }
}
