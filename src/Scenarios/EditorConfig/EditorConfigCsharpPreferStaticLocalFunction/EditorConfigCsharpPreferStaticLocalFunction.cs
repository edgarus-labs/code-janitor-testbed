namespace Testbed.EditorConfig.EditorConfigCsharpPreferStaticLocalFunction;

public class EditorConfigCsharpPreferStaticLocalFunction
{
    public int Use(int x)
    {
        int Local(int y)
        {
            return y + 1;
        }

        return Local(x);
    }

    public static string Run() => new EditorConfigCsharpPreferStaticLocalFunction().Use(1).ToString();
}
