namespace Testbed.Settings.ConvertToCollectionExpressions;

using System.Collections.Generic;

public class ConvertToCollectionExpressions
{
    public static string Run()
    {
        int[] numbers = new int[] { 1, 2, 3 };
        List<string> names = new List<string> { "a", "b" };

        return (numbers.Length + names.Count).ToString();
    }
}
