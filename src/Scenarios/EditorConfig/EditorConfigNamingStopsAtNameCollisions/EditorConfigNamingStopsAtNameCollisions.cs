namespace Testbed.EditorConfig.EditorConfigNamingStopsAtNameCollisions;

public class EditorConfigNamingStopsAtNameCollisions
{
    private int Count = 1;
    private int _count = 2;

    public static string Run()
    {
        EditorConfigNamingStopsAtNameCollisions instance = new EditorConfigNamingStopsAtNameCollisions();

        return (instance.Count + instance._count).ToString();
    }
}
