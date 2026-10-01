namespace Testbed.Reorganize.ReorganizeReverseOrderByAccessLevel;

public class ReorganizeReverseOrderByAccessLevel
{
    public static string Run() => new ReorganizeReverseOrderByAccessLevel().Private().ToString();

    public int Public() => 1;

    private int Private() => 2;
}
