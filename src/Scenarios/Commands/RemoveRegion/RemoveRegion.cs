namespace Testbed.Commands.RemoveRegion;

public class RemoveRegion
{
    #region Helpers
    private static int Twice(int x) => x * 2;
    #endregion

    public static string Run() => Twice(2).ToString();
}
