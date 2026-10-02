namespace Testbed.EditorConfig.EditorConfigIDE0100RedundantEquality;

public class EditorConfigIDE0100RedundantEquality
{
    public static string Run()
    {
        bool flag = System.DateTime.MaxValue.Year > 1;

        return (flag == true).ToString() + (flag == false);
    }
}
