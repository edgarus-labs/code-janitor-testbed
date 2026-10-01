namespace Testbed.CodeStyle.CsharpStylePreferTupleSwap;

public class CsharpStylePreferTupleSwap
{
    public (int, int) Swap(int a, int b)
    {
        var temp = a;
        a = b;
        b = temp;

        return (a, b);
    }

    public static string Run() => new CsharpStylePreferTupleSwap().Swap(1, 2).ToString();
}
