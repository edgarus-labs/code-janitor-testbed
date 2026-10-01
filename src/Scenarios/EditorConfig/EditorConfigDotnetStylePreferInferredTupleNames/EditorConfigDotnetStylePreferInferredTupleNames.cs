namespace Testbed.EditorConfig.EditorConfigDotnetStylePreferInferredTupleNames;

public class EditorConfigDotnetStylePreferInferredTupleNames
{
    public object Inferred(int left, int right)
    {
        var tuple = (left: left, right: right);

        return tuple;
    }

    public static string Run() => new EditorConfigDotnetStylePreferInferredTupleNames().Inferred(1, 2).ToString() ?? "";
}
