namespace Testbed.CodeStyle.DotnetStylePreferSimplifiedInterpolation;

public class DotnetStylePreferSimplifiedInterpolation
{
    public string Format(int value)
    {
        return $"{value.ToString()} items";
    }

    public static string Run() => new DotnetStylePreferSimplifiedInterpolation().Format(3);
}
