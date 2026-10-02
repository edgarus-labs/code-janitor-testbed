namespace Testbed.Settings.UpdateSingleLineMethods;

public class UpdateSingleLineMethods
{
    private int _count;

    public void Increment() { _count++; }

    public static string Run()
    {
        var instance = new UpdateSingleLineMethods();
        instance.Increment();

        return instance._count.ToString();
    }
}
