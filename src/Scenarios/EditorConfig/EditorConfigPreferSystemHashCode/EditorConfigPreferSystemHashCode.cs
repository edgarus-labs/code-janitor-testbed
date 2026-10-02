namespace Testbed.EditorConfig.EditorConfigPreferSystemHashCode;

public class EditorConfigPreferSystemHashCode
{
    public int A = 1;
    public int B = 2;

    public override int GetHashCode()
    {
        return A * 31 + B;
    }

    public override bool Equals(object? obj) => obj is EditorConfigPreferSystemHashCode other && other.A == A && other.B == B;

    public static string Run() => new EditorConfigPreferSystemHashCode().GetHashCode().ToString();
}
