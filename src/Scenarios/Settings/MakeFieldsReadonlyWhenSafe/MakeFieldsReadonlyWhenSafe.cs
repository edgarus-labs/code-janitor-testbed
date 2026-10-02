namespace Testbed.Settings.MakeFieldsReadonlyWhenSafe;

public class MakeFieldsReadonlyWhenSafe
{
    private int _fixed = 1;
    private int _written;

    public void Write()
    {
        _written = 2;
    }

    public static string Run()
    {
        var instance = new MakeFieldsReadonlyWhenSafe();
        instance.Write();

        return (instance._fixed + instance._written).ToString();
    }
}
