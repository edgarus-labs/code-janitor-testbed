namespace Testbed.EditorConfig.EditorConfigDotnetStylePreferInferredAnonymousTypeMemberNames;

public class Person
{
    public string Name { get; set; } = "x";
}

public class EditorConfigDotnetStylePreferInferredAnonymousTypeMemberNames
{
    private Person Initialize() => new Person();

    public object Inferred(int right)
    {
        var anonymous = new { Name = Initialize().Name, Right = right };

        return anonymous;
    }

    public static string Run() => new EditorConfigDotnetStylePreferInferredAnonymousTypeMemberNames().Inferred(1).ToString() ?? "";
}
