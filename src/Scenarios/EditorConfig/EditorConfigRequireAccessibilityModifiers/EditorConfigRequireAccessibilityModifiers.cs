namespace Testbed.EditorConfig.EditorConfigRequireAccessibilityModifiers;

public class EditorConfigRequireAccessibilityModifiers
{
    int _value = 1;

    int Get() { return _value; }

    public static string Run() => new EditorConfigRequireAccessibilityModifiers().Get().ToString();
}
