namespace Testbed.EditorConfig.EditorConfigCA1836IsEmpty;

using System.Collections.Concurrent;

public class EditorConfigCA1836IsEmpty
{
    public static string Run()
    {
        var queue = new ConcurrentQueue<int>();
        var empty = queue.Count == 0;

        return empty.ToString();
    }
}
