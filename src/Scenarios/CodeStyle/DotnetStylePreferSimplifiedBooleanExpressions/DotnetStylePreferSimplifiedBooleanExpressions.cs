namespace Testbed.CodeStyle.DotnetStylePreferSimplifiedBooleanExpressions;

public class DotnetStylePreferSimplifiedBooleanExpressions
{
    public bool Simplify(bool flag, bool other)
    {
        return flag ? true : (other ? flag : false);
    }

    public static string Run() => new DotnetStylePreferSimplifiedBooleanExpressions().Simplify(true, false).ToString();
}
