namespace Testbed.CodeStyle.DotnetStylePreferInferredTupleNames;

public class DotnetStylePreferInferredTupleNames
{
    public object Inferred(int left, int right)
    {
        var tuple = (left: left, right: right);

        return tuple;
    }

    public static string Run() => new DotnetStylePreferInferredTupleNames().Inferred(1, 2).ToString() ?? "";
}
