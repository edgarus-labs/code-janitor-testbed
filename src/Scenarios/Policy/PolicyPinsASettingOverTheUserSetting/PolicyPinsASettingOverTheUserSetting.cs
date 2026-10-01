namespace Testbed.Policy.PolicyPinsASettingOverTheUserSetting;

public class PolicyPinsASettingOverTheUserSetting
{
    #region Helpers
    private static int Twice(int x) => x * 2;
    #endregion

    public static string Run() => Twice(2).ToString();
}
