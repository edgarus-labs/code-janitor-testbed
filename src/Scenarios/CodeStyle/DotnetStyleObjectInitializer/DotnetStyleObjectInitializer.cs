namespace Testbed.CodeStyle.DotnetStyleObjectInitializer;

public class Person
{
    public string Name { get; set; } = "";

    public int Age { get; set; }
}

public class DotnetStyleObjectInitializer
{
    public Person Initialize()
    {
        var person = new Person();
        person.Name = "Ann";
        person.Age = 30;

        return person;
    }

    public static string Run() => new DotnetStyleObjectInitializer().Initialize().Name;
}
