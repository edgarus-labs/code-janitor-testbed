namespace Testbed.CodeStyle.CsharpStyleUnusedValueAssignmentPreference;

public class CsharpStyleUnusedValueAssignmentPreference
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

    public static string Run() => new CsharpStyleUnusedValueAssignmentPreference().Unused().ToString();
}
