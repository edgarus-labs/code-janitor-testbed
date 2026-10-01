namespace Testbed.CodeStyle.DotnetStylePreferAutoProperties;

public class DotnetStylePreferAutoProperties
{
    private int _age;

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public static string Run()
    {
        var instance = new DotnetStylePreferAutoProperties();
        instance.Age = 5;

        return instance.Age.ToString();
    }
}
