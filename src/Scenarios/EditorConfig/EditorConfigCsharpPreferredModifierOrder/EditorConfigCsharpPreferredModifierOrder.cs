namespace Testbed.EditorConfig.EditorConfigCsharpPreferredModifierOrder;

public class EditorConfigCsharpPreferredModifierOrder
{
    static public int Counter;
    readonly private int _seed = 1;

    public static string Run() => (new EditorConfigCsharpPreferredModifierOrder()._seed + Counter).ToString();
}
