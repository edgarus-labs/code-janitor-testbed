namespace Testbed.EditorConfig.EditorConfigIDE0241NullableDisableBeforeEnum;

#nullable disable
public enum EditorConfigIDE0241Level
{
    Low,
    High,
}
#nullable restore

public class EditorConfigIDE0241NullableDisableBeforeEnum
{
    public static string Run() => EditorConfigIDE0241Level.High.ToString();
}
