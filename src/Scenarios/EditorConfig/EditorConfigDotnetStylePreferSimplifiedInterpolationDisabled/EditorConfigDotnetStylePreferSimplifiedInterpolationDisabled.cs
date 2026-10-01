namespace Testbed.EditorConfig.EditorConfigDotnetStylePreferSimplifiedInterpolationDisabled;

public class EditorConfigDotnetStylePreferSimplifiedInterpolationDisabled
{
    public string Format(int value)
    {
        return $"{value.ToString()} items";
    }

    public static string Run() => new EditorConfigDotnetStylePreferSimplifiedInterpolationDisabled().Format(3);
}
