namespace Testbed.Reorganize.ReorganizeRunAtStartOfCleanup;

public class ReorganizeRunAtStartOfCleanup
{
    public static string Run() => new ReorganizeRunAtStartOfCleanup().Total().ToString();

    public int Total() => Alpha + _beta + Zeta;

    public int Zeta { get; set; } = 3;

    public ReorganizeRunAtStartOfCleanup() { }

    private int _beta = 2;

    public int Alpha = 1;
}
