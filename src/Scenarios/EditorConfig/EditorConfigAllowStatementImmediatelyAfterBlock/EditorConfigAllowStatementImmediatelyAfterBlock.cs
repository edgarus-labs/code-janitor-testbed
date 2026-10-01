namespace Testbed.EditorConfig.EditorConfigAllowStatementImmediatelyAfterBlock;

public class EditorConfigAllowStatementImmediatelyAfterBlock
{
    public static string Run()
    {
        var value = 1;
        if (value > 0)
        {
            value++;
        }
        value++;

        return value.ToString();
    }
}
