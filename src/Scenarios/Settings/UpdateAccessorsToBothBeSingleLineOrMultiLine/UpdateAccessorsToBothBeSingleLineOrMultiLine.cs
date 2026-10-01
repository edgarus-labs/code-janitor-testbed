namespace Testbed.Settings.UpdateAccessorsToBothBeSingleLineOrMultiLine;

public class UpdateAccessorsToBothBeSingleLineOrMultiLine
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set
        {
            _value = value;
        }
    }

    public static string Run()
    {
        var instance = new UpdateAccessorsToBothBeSingleLineOrMultiLine();
        instance.Value = 2;

        return instance.Value.ToString();
    }
}
