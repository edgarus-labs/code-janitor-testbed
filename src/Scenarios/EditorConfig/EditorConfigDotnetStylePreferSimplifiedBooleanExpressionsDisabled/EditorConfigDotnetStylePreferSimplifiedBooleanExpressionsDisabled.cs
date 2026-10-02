namespace Testbed.EditorConfig.EditorConfigDotnetStylePreferSimplifiedBooleanExpressionsDisabled;

public class EditorConfigDotnetStylePreferSimplifiedBooleanExpressionsDisabled
{
    public bool Simplify(bool flag, bool other)
    {
        return flag ? true : (other ? flag : false);
    }

    public static string Run() => new EditorConfigDotnetStylePreferSimplifiedBooleanExpressionsDisabled().Simplify(true, false).ToString();
}
