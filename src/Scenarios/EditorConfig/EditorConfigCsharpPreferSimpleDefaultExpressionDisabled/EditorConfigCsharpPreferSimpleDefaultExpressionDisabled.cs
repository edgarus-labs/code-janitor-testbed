namespace Testbed.EditorConfig.EditorConfigCsharpPreferSimpleDefaultExpressionDisabled;

public class EditorConfigCsharpPreferSimpleDefaultExpressionDisabled
{
    public int Defaults()
    {
        return default(int);
    }

    public static string Run() => new EditorConfigCsharpPreferSimpleDefaultExpressionDisabled().Defaults().ToString();
}
