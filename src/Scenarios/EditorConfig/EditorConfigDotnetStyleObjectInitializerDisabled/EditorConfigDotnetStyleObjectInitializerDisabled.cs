namespace Testbed.EditorConfig.EditorConfigDotnetStyleObjectInitializerDisabled;

public class Person
{
    public string Name { get; set; } = "";

    public int Age { get; set; }
}

public class EditorConfigDotnetStyleObjectInitializerDisabled
{
    public Person Initialize()
    {
        var person = new Person();
        person.Name = "Ann";
        person.Age = 30;

        return person;
    }

    public static string Run() => new EditorConfigDotnetStyleObjectInitializerDisabled().Initialize().Name;
}
