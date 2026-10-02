namespace Testbed.EditorConfig.EditorConfigDotnetStyleExplicitTupleNamesDisabled;

public class EditorConfigDotnetStyleExplicitTupleNamesDisabled
{
    public int ExplicitNames()
    {
        (int Left, int Right) tuple = (1, 2);

        return tuple.Item1 + tuple.Right;
    }

    public static string Run() => new EditorConfigDotnetStyleExplicitTupleNamesDisabled().ExplicitNames().ToString();
}
