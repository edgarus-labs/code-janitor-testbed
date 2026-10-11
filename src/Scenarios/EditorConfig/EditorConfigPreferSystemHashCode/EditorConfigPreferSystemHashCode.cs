namespace Testbed.EditorConfig.EditorConfigPreferSystemHashCode;

public class EditorConfigPreferSystemHashCode
{
    public int A = 1;
    public int B = 2;

    public override int GetHashCode()
    {
        var hashCode = -1817952719;
        hashCode = hashCode * -1521134295 + A.GetHashCode();
        hashCode = hashCode * -1521134295 + B.GetHashCode();
        return hashCode;
    }

    public override bool Equals(object? obj) => obj is EditorConfigPreferSystemHashCode other && other.A == A && other.B == B;

    public static string Run() => (new EditorConfigPreferSystemHashCode().GetHashCode() == new EditorConfigPreferSystemHashCode().GetHashCode()).ToString();
}
