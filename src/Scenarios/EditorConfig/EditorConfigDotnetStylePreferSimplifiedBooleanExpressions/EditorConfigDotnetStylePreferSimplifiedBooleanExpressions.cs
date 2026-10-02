namespace Testbed.EditorConfig.EditorConfigDotnetStylePreferSimplifiedBooleanExpressions;

public class EditorConfigDotnetStylePreferSimplifiedBooleanExpressions
{
    public bool Simplify(bool flag, bool other)
    {
        return flag ? true : (other ? flag : false);
    }

    public static string Run() => new EditorConfigDotnetStylePreferSimplifiedBooleanExpressions().Simplify(true, false).ToString();
}
