namespace Testbed.EditorConfig.EditorConfigDotnetStylePreferAutoProperties;

public class EditorConfigDotnetStylePreferAutoProperties
{
    private int _age;

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public static string Run()
    {
        var instance = new EditorConfigDotnetStylePreferAutoProperties();
        instance.Age = 5;

        return instance.Age.ToString();
    }
}
