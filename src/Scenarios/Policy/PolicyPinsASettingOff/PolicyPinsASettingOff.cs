namespace Testbed.Policy.PolicyPinsASettingOff;

public class PolicyPinsASettingOff
{
    #region Helpers
    private static int Twice(int x) => x * 2;
    #endregion

    public static string Run() => Twice(2).ToString();
}
