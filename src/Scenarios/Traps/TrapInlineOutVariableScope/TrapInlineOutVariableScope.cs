namespace Testbed.Traps.TrapInlineOutVariableScope;

public class TrapInlineOutVariableScope
{
    private static int s_calls;

    private static string Next() => (++s_calls < 3 ? s_calls.ToString() : "x");

    public static string Run()
    {
        int number;
        var total = 0;
        while (int.TryParse(Next(), out number))
        {
            total += number;
        }

        return (total + number).ToString();
    }
}
