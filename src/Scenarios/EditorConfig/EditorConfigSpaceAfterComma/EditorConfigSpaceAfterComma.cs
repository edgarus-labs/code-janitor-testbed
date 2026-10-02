namespace Testbed.EditorConfig.EditorConfigSpaceAfterComma;

using System.Linq;

public class EditorConfigSpaceAfterComma
{
    public static string Run()
    {
        var sum = Add(1, 2);

        return sum.ToString();
    }

    private static int Add(int a, int b) => a + b;
}
