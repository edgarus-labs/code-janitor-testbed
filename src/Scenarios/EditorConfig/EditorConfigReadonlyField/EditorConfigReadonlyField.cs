namespace Testbed.EditorConfig.EditorConfigReadonlyField;

public class EditorConfigReadonlyField
{
    private int _value = 1;

    public static string Run() => (new EditorConfigReadonlyField()._value + 1).ToString();
}
