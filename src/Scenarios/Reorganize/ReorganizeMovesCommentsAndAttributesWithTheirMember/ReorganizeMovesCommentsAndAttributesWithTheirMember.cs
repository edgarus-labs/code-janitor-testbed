namespace Testbed.Reorganize.ReorganizeMovesCommentsAndAttributesWithTheirMember;

public class ReorganizeMovesCommentsAndAttributesWithTheirMember
{
    public static string Run() => Name();

    // the name
    [System.Obsolete("old")]
    public static string Name() => "n";

    /// <summary>The count.</summary>
    public int Alpha = 1;
}
