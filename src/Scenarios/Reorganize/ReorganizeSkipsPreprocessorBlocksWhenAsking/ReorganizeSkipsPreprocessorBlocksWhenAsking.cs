namespace Testbed.Reorganize.ReorganizeSkipsPreprocessorBlocksWhenAsking;

public class ReorganizeSkipsPreprocessorBlocksWhenAsking
{
    public static string Run() => Name();

#if DEBUG
    public static string Debug() => "d";
#endif

    public static string Name() => "n";

    public int Alpha = 1;
}
