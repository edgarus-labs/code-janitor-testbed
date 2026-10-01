namespace Testbed.CodeStyle.CsharpPreferStaticLocalFunction;

public class CsharpPreferStaticLocalFunction
{
    public int Use(int x)
    {
        int Local(int y)
        {
            return y + 1;
        }

        return Local(x);
    }

    public static string Run() => new CsharpPreferStaticLocalFunction().Use(1).ToString();
}
