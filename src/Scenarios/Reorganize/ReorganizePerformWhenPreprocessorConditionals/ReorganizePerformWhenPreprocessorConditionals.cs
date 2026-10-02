namespace Testbed.Reorganize.ReorganizePerformWhenPreprocessorConditionals;

public class ReorganizePerformWhenPreprocessorConditionals
{
    public static string Run() => Name();

#if DEBUG
    public static string Debug() => "d";
#endif

    public static string Name() => "n";

    public int Alpha = 1;
}
