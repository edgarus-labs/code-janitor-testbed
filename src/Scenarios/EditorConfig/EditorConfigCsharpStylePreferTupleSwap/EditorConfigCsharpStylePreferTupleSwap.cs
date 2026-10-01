namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferTupleSwap;

public class EditorConfigCsharpStylePreferTupleSwap
{
    public (int, int) Swap(int a, int b)
    {
        var temp = a;
        a = b;
        b = temp;

        return (a, b);
    }

    public static string Run() => new EditorConfigCsharpStylePreferTupleSwap().Swap(1, 2).ToString();
}
