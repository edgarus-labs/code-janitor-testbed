namespace Testbed.Policy.PolicyCodeStyleNullDisablesAUserRule;

public class PolicyCodeStyleNullDisablesAUserRule
{
    public static string Run()
    {
        var text = "";
        if (text.Length == 0)
            text = "empty";

        return text;
    }
}
