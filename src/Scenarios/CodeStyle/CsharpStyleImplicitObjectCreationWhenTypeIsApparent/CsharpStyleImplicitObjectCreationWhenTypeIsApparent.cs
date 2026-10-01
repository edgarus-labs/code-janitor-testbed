namespace Testbed.CodeStyle.CsharpStyleImplicitObjectCreationWhenTypeIsApparent;

public class Dependency
{
}

public class CsharpStyleImplicitObjectCreationWhenTypeIsApparent
{
    private readonly Dependency _other = new Dependency();

    public static string Run() => new CsharpStyleImplicitObjectCreationWhenTypeIsApparent()._other is not null ? "ok" : "none";
}
