namespace Testbed.Reorganize.ReorganizePrimaryOrderByAccessLevel;

public class ReorganizePrimaryOrderByAccessLevel
{
    private int _hidden = 1;

    public static string Run() => new ReorganizePrimaryOrderByAccessLevel()._hidden.ToString();

    private int Helper() => _hidden;

    public int Visible() => Helper();
}
