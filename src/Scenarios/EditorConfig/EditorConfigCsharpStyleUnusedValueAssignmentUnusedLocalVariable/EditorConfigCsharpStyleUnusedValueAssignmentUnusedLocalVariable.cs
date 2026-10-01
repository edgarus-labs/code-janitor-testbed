namespace Testbed.EditorConfig.EditorConfigCsharpStyleUnusedValueAssignmentUnusedLocalVariable;

public class EditorConfigCsharpStyleUnusedValueAssignmentUnusedLocalVariable
{
    public static string Run()
    {
        int result = Compute();
        result = Compute();

        return result.ToString();
    }

    private static int Compute() => 42;
}
