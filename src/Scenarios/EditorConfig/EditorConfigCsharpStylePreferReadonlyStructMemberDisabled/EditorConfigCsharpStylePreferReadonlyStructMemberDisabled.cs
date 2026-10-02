namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferReadonlyStructMemberDisabled;

public struct Tally
{
    private int _value;

    public int Current()
    {
        return _value;
    }

    public void Increment()
    {
        _value++;
    }
}

public class EditorConfigCsharpStylePreferReadonlyStructMemberDisabled
{
    public static string Run()
    {
        var tally = new Tally();
        tally.Increment();

        return tally.Current().ToString();
    }
}
