namespace Testbed.EditorConfig.EditorConfigCA1852SealInternalType;

internal class Leaf
{
    internal int Value => 1;
}

public class EditorConfigCA1852SealInternalType
{
    public static string Run() => new Leaf().Value.ToString();
}
