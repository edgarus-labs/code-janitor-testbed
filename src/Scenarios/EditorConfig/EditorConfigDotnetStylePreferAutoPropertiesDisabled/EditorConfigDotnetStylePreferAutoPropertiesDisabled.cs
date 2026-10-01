namespace Testbed.EditorConfig.EditorConfigDotnetStylePreferAutoPropertiesDisabled;

public class EditorConfigDotnetStylePreferAutoPropertiesDisabled
{
    private int _age;

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public static string Run()
    {
        var instance = new EditorConfigDotnetStylePreferAutoPropertiesDisabled();
        instance.Age = 5;

        return instance.Age.ToString();
    }
}
