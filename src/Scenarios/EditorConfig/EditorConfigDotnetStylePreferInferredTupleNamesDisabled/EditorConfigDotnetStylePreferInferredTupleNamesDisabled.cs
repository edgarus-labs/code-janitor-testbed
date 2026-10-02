namespace Testbed.EditorConfig.EditorConfigDotnetStylePreferInferredTupleNamesDisabled;

public class EditorConfigDotnetStylePreferInferredTupleNamesDisabled
{
    public object Inferred(int left, int right)
    {
        var tuple = (left: left, right: right);

        return tuple;
    }

    public static string Run() => new EditorConfigDotnetStylePreferInferredTupleNamesDisabled().Inferred(1, 2).ToString() ?? "";
}
