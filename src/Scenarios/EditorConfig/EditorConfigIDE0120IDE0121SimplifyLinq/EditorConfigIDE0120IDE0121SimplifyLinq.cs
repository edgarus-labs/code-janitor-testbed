namespace Testbed.EditorConfig.EditorConfigIDE0120IDE0121SimplifyLinq;

using System.Collections.Generic;
using System.Linq;

public class EditorConfigIDE0120IDE0121SimplifyLinq
{
    public static string Run()
    {
        IEnumerable<int> numbers = new[] { 1, 2, 3 };
        IEnumerable<object> things = new object[] { "a", 1 };
        var any = numbers.Where(n => n > 1).Any();
        var texts = things.Where(t => t is string).Cast<string>();

        return any + "," + texts.Count();
    }
}
