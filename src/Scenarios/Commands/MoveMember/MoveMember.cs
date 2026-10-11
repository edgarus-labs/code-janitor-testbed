namespace Testbed.Commands.MoveMember;

public class MoveMember
{
    /// <summary>Doubles.</summary>
    private static int Twice(int x) => x * 2;

    private static int Thrice(int x) => x * 3;

    public static string Run()
    {
        return (Twice(2) + Thrice(3)).ToString();
    }
}
