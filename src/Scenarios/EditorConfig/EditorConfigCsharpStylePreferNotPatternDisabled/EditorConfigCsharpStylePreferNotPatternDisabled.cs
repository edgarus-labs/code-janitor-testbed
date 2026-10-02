namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferNotPatternDisabled;

public class EditorConfigCsharpStylePreferNotPatternDisabled
{
    public bool NotString(object value)
    {
        return !(value is string);
    }

    public static string Run() => new EditorConfigCsharpStylePreferNotPatternDisabled().NotString(1).ToString();
}
