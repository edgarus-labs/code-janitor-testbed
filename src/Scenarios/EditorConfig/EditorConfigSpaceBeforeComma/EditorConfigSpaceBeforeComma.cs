namespace Testbed.EditorConfig.EditorConfigSpaceBeforeComma;

using System.Linq;

public class EditorConfigSpaceBeforeComma
{
    public static string Run()
    {
        var sum = Add(1, 2);

        return sum.ToString();
    }

    private static int Add(int a, int b) => a + b;
}
