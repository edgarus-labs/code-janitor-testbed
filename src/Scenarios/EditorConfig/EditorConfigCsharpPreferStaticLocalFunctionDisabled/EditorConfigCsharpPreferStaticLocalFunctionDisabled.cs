namespace Testbed.EditorConfig.EditorConfigCsharpPreferStaticLocalFunctionDisabled;

public class EditorConfigCsharpPreferStaticLocalFunctionDisabled
{
    public int Use(int x)
    {
        int Local(int y)
        {
            return y + 1;
        }

        return Local(x);
    }

    public static string Run() => new EditorConfigCsharpPreferStaticLocalFunctionDisabled().Use(1).ToString();
}
