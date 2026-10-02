namespace Testbed.EditorConfig.EditorConfigIDE0030NullableCoalesce;

public class EditorConfigIDE0030NullableCoalesce
{
    public static string Run()
    {
        int? maybe = null;
        var value = maybe.HasValue ? maybe.Value : 0;

        return value.ToString();
    }
}
