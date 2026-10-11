namespace Testbed.Settings.InsertBlankLinePaddingBetweenPropertiesMultiLineAccessors;

public class InsertBlankLinePaddingBetweenPropertiesMultiLineAccessors
{
    private int _value = 1;

    public int Value
    {
        get
        {
            return _value;
        }
        set
        {
            _value = value;
        }
    }

    public static string Run()
    {
        var instance = new InsertBlankLinePaddingBetweenPropertiesMultiLineAccessors { Value = 3 };

        return instance.Value.ToString();
    }
}
