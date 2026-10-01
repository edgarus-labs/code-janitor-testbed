namespace Testbed.Settings.SimplifySingleStatementLambdas;

using System;

public class SimplifySingleStatementLambdas
{
    public static string Run()
    {
        Func<int, int> twice = x => { return x * 2; };

        return twice(4).ToString();
    }
}
