namespace Testbed.Traps.TrapNullCheckInExpressionTree;

using System;
using System.Linq.Expressions;

public class TrapNullCheckInExpressionTree
{
    public static string Run()
    {
        Expression<Func<string?, bool>> isNull = text => text == null;
        Expression<Func<int[], int>> last = values => values[values.Length - 1];

        return isNull.Compile()(null) + "," + last.Compile()(new[] { 1, 2, 3 });
    }
}
