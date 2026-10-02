namespace Testbed.Traps.TrapQualifyOnlyInstanceMembers;

public class TrapQualifyOnlyInstanceMembers
{
    private static int s_count = 2;
    private int _value = 1;

    public int Total() => _value + s_count;

    public static string Run() => new TrapQualifyOnlyInstanceMembers().Total().ToString();
}
