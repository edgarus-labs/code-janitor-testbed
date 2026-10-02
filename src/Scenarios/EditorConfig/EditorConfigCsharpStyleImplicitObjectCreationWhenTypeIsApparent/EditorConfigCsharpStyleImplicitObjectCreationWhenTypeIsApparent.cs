namespace Testbed.EditorConfig.EditorConfigCsharpStyleImplicitObjectCreationWhenTypeIsApparent;

public class Dependency
{
}

public class EditorConfigCsharpStyleImplicitObjectCreationWhenTypeIsApparent
{
    private readonly Dependency _other = new Dependency();

    public static string Run() => new EditorConfigCsharpStyleImplicitObjectCreationWhenTypeIsApparent()._other is not null ? "ok" : "none";
}
