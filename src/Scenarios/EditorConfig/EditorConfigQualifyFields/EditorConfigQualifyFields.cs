namespace Testbed.EditorConfig.EditorConfigQualifyFields;

public class EditorConfigQualifyFields
{
    private int _count = 1;

    public int Next() => _count + 1;

    public static string Run() => new EditorConfigQualifyFields().Next().ToString();
}
