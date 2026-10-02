namespace Testbed.EditorConfig.EditorConfigIDE0306NewCollectionWithSource;

using System.Collections.Generic;

public class EditorConfigIDE0306NewCollectionWithSource
{
    public static string Run()
    {
        int[] source = { 1, 2 };
        List<int> copy = new List<int>(source);

        return copy.Count.ToString();
    }
}
