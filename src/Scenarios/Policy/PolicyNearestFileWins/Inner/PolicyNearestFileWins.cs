namespace Testbed.Policy.PolicyNearestFileWins;

public class PolicyNearestFileWins
{
    #region Helpers
    private static int Twice(int x) => x * 2;
    #endregion

    public static string Run() => Twice(2).ToString();
}
