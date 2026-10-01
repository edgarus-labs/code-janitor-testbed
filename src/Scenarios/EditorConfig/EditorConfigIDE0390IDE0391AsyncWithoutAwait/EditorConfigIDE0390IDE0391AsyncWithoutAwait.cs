namespace Testbed.EditorConfig.EditorConfigIDE0390IDE0391AsyncWithoutAwait;

using System.Threading.Tasks;

public class EditorConfigIDE0390IDE0391AsyncWithoutAwait
{
    public class Base
    {
        public virtual Task<string> Get() => Task.FromResult("a");
    }

    public class Derived : Base
    {
        public override async Task<string> Get() => "b";
    }

    private static async Task<string> Plain() => "c";

    public static string Run() => new Derived().Get().GetAwaiter().GetResult() + Plain().GetAwaiter().GetResult();
}
