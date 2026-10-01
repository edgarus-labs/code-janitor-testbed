namespace Testbed.EditorConfig.EditorConfigNamingTypesAreReportedNotRenamed;

public class EditorConfigNamingTypesAreReportedNotRenamed
{
    private interface Marker
    {
    }

    private sealed class Impl : Marker
    {
    }

    public static string Run() => new Impl().GetType().Name;
}
