namespace Testbed.Traps.TrapCollectionExpressionTargets;

using System.Collections.Generic;

public class TrapCollectionExpressionTargets
{
    public static string Run()
    {
        IEnumerable<int> sequence = new int[] { 1, 2 };
        var list = new List<int> { 3, 4 };
        object boxed = new[] { "a" };

        return string.Concat(sequence) + list.Count + ((string[])boxed).Length;
    }
}
