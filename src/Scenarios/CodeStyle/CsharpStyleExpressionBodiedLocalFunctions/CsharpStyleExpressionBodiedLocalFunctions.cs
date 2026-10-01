namespace Testbed.CodeStyle.CsharpStyleExpressionBodiedLocalFunctions;

public class CsharpStyleExpressionBodiedLocalFunctions
{
    public int Twice(int value)
    {
        int Local(int x) => x * 2;

        return Local(value);
    }

    public static string Run() => new CsharpStyleExpressionBodiedLocalFunctions().Twice(4).ToString();
}
