namespace Testbed.EditorConfig.EditorConfigNamingPrivateFields;

public class EditorConfigNamingPrivateFields
{
    private int Count = 1;

    public int Next() => Count + 1;

    public static string Run() => new EditorConfigNamingPrivateFields().Next().ToString();
}
