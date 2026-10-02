namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferTupleSwapDisabled;

public class EditorConfigCsharpStylePreferTupleSwapDisabled
{
    public (int, int) Swap(int a, int b)
    {
        var temp = a;
        a = b;
        b = temp;

        return (a, b);
    }

    public static string Run() => new EditorConfigCsharpStylePreferTupleSwapDisabled().Swap(1, 2).ToString();
}
