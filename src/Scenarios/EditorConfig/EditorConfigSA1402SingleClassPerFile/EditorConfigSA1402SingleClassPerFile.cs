namespace Testbed.EditorConfig.EditorConfigSA1402SingleClassPerFile;

public class EditorConfigSA1402SingleClassPerFile
{
    public static string Run() => new SingleClassHelper().Name;
}

public class SingleClassHelper
{
    public string Name => "helper";
}
