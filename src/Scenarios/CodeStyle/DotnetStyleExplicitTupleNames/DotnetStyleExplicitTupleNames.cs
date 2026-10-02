namespace Testbed.CodeStyle.DotnetStyleExplicitTupleNames;

public class DotnetStyleExplicitTupleNames
{
    public int ExplicitNames()
    {
        (int Left, int Right) tuple = (1, 2);

        return tuple.Item1 + tuple.Right;
    }

    public static string Run() => new DotnetStyleExplicitTupleNames().ExplicitNames().ToString();
}
