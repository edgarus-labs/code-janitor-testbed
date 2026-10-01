namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferPrimaryConstructors;

public class Dependency
{
}

public class Service
{
    private readonly Dependency _dependency;

    public Service(Dependency dependency)
    {
        _dependency = dependency;
    }

    public Dependency Get()
    {
        return _dependency;
    }
}

public class EditorConfigCsharpStylePreferPrimaryConstructors
{
    public static string Run() => new Service(new Dependency()).Get() is not null ? "ok" : "none";
}
