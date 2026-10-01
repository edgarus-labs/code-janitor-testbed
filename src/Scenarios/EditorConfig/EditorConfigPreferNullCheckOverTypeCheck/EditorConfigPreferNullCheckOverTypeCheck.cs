namespace Testbed.EditorConfig.EditorConfigPreferNullCheckOverTypeCheck;

public class EditorConfigPreferNullCheckOverTypeCheck
{
    public static bool Has(object? value) => value is object;

    public static string Run() => Has("a").ToString();
}
