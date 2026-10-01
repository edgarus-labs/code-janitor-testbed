namespace Testbed.EditorConfig.EditorConfigCsharpStyleImplicitObjectCreationWhenTypeIsApparentDisabled;

public class Dependency
{
}

public class EditorConfigCsharpStyleImplicitObjectCreationWhenTypeIsApparentDisabled
{
    private readonly Dependency _other = new Dependency();

    public static string Run() => new EditorConfigCsharpStyleImplicitObjectCreationWhenTypeIsApparentDisabled()._other is not null ? "ok" : "none";
}
