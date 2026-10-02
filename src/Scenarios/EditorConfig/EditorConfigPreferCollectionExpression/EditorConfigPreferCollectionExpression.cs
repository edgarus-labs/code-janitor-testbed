namespace Testbed.EditorConfig.EditorConfigPreferCollectionExpression;

public class EditorConfigPreferCollectionExpression
{
    public static string Run()
    {
        int[] array = new int[] { 1, 2, 3 };
        System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int> { 1, 2 };

        return (array.Length + list.Count).ToString();
    }
}
