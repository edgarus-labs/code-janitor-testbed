namespace Testbed.EditorConfig.EditorConfigNamingAmbiguousReferencesAreReported;

public class EditorConfigNamingAmbiguousReferencesAreReported
{
    private int Count = 2;

    public static string Run()
    {
        var instance = new EditorConfigNamingAmbiguousReferencesAreReported();

        return instance.Count.ToString();
    }
}
