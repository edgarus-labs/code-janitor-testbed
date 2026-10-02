namespace Testbed.EditorConfig.EditorConfigCsharpPreferSimpleDefaultExpression;

public class EditorConfigCsharpPreferSimpleDefaultExpression
{
    public int Defaults()
    {
        return default(int);
    }

    public static string Run() => new EditorConfigCsharpPreferSimpleDefaultExpression().Defaults().ToString();
}
