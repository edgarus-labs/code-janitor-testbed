namespace Testbed.EditorConfig.EditorConfigPreserveSingleLineBlocks;

public class EditorConfigPreserveSingleLineBlocks
{
    public int Count { get; set; }

    public static string Run()
    {
        var instance = new EditorConfigPreserveSingleLineBlocks { Count = 2 };

        return instance.Count.ToString();
    }
}
