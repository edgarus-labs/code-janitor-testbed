namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferReadonlyStruct;

public struct ImmutablePoint
{
    public ImmutablePoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; }

    public int Y { get; }
}

public class EditorConfigCsharpStylePreferReadonlyStruct
{
    public static string Run() => new ImmutablePoint(1, 2).X.ToString();
}
