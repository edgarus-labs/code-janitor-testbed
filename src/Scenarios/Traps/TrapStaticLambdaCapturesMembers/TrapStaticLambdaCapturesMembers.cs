namespace Testbed.Traps.TrapStaticLambdaCapturesMembers;

using System;
using System.Linq;

public class TrapStaticLambdaCapturesMembers
{
    private readonly int _offset = 3;
    private object? _scope = "scope";

    public Func<object?> Scope() => () => _scope;

    public Func<int, int> Shift() => value => value + _offset;

    public string[] Describe(string[] ids, int width) => ids.Select(id => $"{id}:{width}").ToArray();

    public static string Run()
    {
        var instance = new TrapStaticLambdaCapturesMembers();

        return instance.Scope()() + "," + instance.Shift()(1) + "," + string.Concat(instance.Describe(new[] { "a" }, 2));
    }
}
