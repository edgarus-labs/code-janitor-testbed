namespace Testbed.Settings.InsertBlankLineBeforeReturnAndThrowStatements;

public class InsertBlankLineBeforeReturnAndThrowStatements
{
    public static string Run()
    {
        var value = 1;
        value++;
        return value.ToString();
    }

    public static void Fail(int n)
    {
        n++;
        if (n > 100)
            throw new System.InvalidOperationException();
    }
}
