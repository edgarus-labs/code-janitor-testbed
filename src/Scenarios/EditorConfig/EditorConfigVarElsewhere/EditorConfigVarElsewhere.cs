namespace Testbed.EditorConfig.EditorConfigVarElsewhere;

public class EditorConfigVarElsewhere
{
    private static System.Collections.Generic.List<int> Make() => new();

    public static string Run()
    {
        var items = Make();

        return items.Count.ToString();
    }
}
