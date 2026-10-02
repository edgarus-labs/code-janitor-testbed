namespace Testbed.EditorConfig.EditorConfigNamingCamelCaseParameters;

public class EditorConfigNamingCamelCaseParameters
{
    private static int Add(int First, int Second) => First + Second;

    public static string Run() => Add(1, 2).ToString();
}
