namespace Testbed.EditorConfig.EditorConfigCsharpStyleUnusedValueAssignmentPreference;

public class EditorConfigCsharpStyleUnusedValueAssignmentPreference
{
    public int Unused()
    {
        int result = Compute();
        result = Compute();

        return result;
    }

    private static int Compute()
    {
        return 42;
    }

    public static string Run() => new EditorConfigCsharpStyleUnusedValueAssignmentPreference().Unused().ToString();
}
