namespace Testbed.CodeStyle.CsharpPreferSimpleDefaultExpression;

public class CsharpPreferSimpleDefaultExpression
{
    public int Defaults()
    {
        return default(int);
    }

    public static string Run() => new CsharpPreferSimpleDefaultExpression().Defaults().ToString();
}
