namespace Testbed.EditorConfig.EditorConfigNamingExplicitTypeAllowsFieldRename;

public class EditorConfigNamingExplicitTypeAllowsFieldRename
{
    private int Count = 2;

    public static string Run()
    {
        EditorConfigNamingExplicitTypeAllowsFieldRename instance = new EditorConfigNamingExplicitTypeAllowsFieldRename();

        return instance.Count.ToString();
    }
}
