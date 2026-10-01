namespace Testbed.CodeStyle.CsharpPreferredModifierOrder;

public class CsharpPreferredModifierOrder
{
    static public int Counter;
    readonly private int _seed = 1;

    public static string Run() => (new CsharpPreferredModifierOrder()._seed + Counter).ToString();
}
