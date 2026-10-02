namespace Testbed.EditorConfig.EditorConfigNamingLocalsAndParameters;

public class EditorConfigNamingLocalsAndParameters
{
    private static int Add(int First, int Second)
    {
        var Sum = First + Second;

        return Sum;
    }

    public static string Run() => Add(1, 2).ToString();
}
