namespace Testbed.Traps.TrapVarWhereTypeIsNotApparent;

using System.Collections.Generic;

public class TrapVarWhereTypeIsNotApparent
{
    public static string Run()
    {
        string? name = null;
        int[] numbers = { 1, 2 };
        object boxed = "x";
        IEnumerable<int> sequence = new List<int> { 3 };

        return (name ?? "none") + numbers.Length + boxed + sequence;
    }
}
