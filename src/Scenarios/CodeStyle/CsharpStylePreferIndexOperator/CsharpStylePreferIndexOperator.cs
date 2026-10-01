namespace Testbed.CodeStyle.CsharpStylePreferIndexOperator;

public class CsharpStylePreferIndexOperator
{
    public int Last(int[] values)
    {
        return values[values.Length - 1];
    }

    public static string Run() => new CsharpStylePreferIndexOperator().Last(new[] { 1, 2, 3 }).ToString();
}
