namespace Testbed.Traps.TrapLambdaOverloadBinding;

using System;

public class TrapLambdaOverloadBinding
{
    private static int s_total;

    private static int Counter() => ++s_total;

    private static string Apply(Action action)
    {
        action();

        return "action";
    }

    private static string Apply(Func<int> function) => "func" + function();

    public static string Run() => Apply(() => { Counter(); }) + Apply(() => { return Counter(); });
}
