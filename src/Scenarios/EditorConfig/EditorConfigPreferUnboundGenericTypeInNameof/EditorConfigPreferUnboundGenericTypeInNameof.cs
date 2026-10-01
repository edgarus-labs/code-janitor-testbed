namespace Testbed.EditorConfig.EditorConfigPreferUnboundGenericTypeInNameof;

public class EditorConfigPreferUnboundGenericTypeInNameof
{
    public static string Run() => nameof(System.Collections.Generic.List<int>);
}
