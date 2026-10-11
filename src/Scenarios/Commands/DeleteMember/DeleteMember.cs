namespace Testbed.Commands.DeleteMember;

public class DeleteMember
{
    private static int Twice(int x) => x * 2;

    /// <summary>Unused.</summary>
    [System.Obsolete]
    private static int Unused(int x) => x;

    private static int Thrice(int x) => x * 3;

    public static string Run()
    {
        return (Twice(2) + Thrice(3)).ToString();
    }
}
