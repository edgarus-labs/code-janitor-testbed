namespace Testbed.EditorConfig.EditorConfigCA1825EmptyArrays;

public class EditorConfigCA1825EmptyArrays
{
    public static string Run()
    {
        var numbers = new int[0];
        var names = new string[] { };

        return (numbers.Length + names.Length).ToString();
    }
}
