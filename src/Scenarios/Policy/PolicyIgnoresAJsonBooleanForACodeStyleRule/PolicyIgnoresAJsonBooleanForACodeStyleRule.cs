namespace Testbed.Policy.PolicyIgnoresAJsonBooleanForACodeStyleRule;

public class PolicyIgnoresAJsonBooleanForACodeStyleRule
{
    public static string Run()
    {
        var text = "";
        if (text.Length == 0)
            text = "empty";

        return text;
    }
}
