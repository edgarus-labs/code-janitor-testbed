namespace Testbed.Traps.TrapFormatArgumentsWithSideEffects;

public class TrapFormatArgumentsWithSideEffects
{
    private static int s_counter;

    private static int Next() => ++s_counter;

    public static string Run() => string.Format("{0}-{0}", Next()) + string.Format("{1}{0}", Next(), Next());
}
