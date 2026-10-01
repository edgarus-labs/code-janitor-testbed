namespace Testbed.EditorConfig.EditorConfigSimplePropertyAccessors;

public class EditorConfigSimplePropertyAccessors
{
    public int Value
    {
        get { return field; }
        set { field = value; }
    }

    public static string Run()
    {
        var instance = new EditorConfigSimplePropertyAccessors();
        instance.Value = 3;

        return instance.Value.ToString();
    }
}
