namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferNotPattern;

public class EditorConfigCsharpStylePreferNotPattern
{
    public bool NotString(object value)
    {
        return !(value is string);
    }

    public static string Run() => new EditorConfigCsharpStylePreferNotPattern().NotString(1).ToString();
}
