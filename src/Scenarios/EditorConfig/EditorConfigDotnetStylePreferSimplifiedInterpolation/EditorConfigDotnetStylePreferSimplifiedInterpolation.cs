namespace Testbed.EditorConfig.EditorConfigDotnetStylePreferSimplifiedInterpolation;

public class EditorConfigDotnetStylePreferSimplifiedInterpolation
{
    public string Format(int value)
    {
        return $"{value.ToString()} items";
    }

    public static string Run() => new EditorConfigDotnetStylePreferSimplifiedInterpolation().Format(3);
}
