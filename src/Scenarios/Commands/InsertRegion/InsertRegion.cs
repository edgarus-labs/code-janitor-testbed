namespace Testbed.Commands.InsertRegion;

public class InsertRegion
{
    private static int Twice(int x) => x * 2;

    private static int Thrice(int x) => x * 3;

    public static string Run() => (Twice(1) + Thrice(1)).ToString();
}
