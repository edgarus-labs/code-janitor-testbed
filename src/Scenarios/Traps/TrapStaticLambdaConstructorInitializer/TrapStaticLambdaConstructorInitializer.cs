namespace Testbed.Traps.TrapStaticLambdaConstructorInitializer;

using System;

public class TrapStaticLambdaConstructorInitializer
{
    private readonly Func<string> _factory;

    public TrapStaticLambdaConstructorInitializer(string device) : this(() => device)
    {
    }

    private TrapStaticLambdaConstructorInitializer(Func<string> factory)
    {
        _factory = factory;
    }

    public static string Run() => new TrapStaticLambdaConstructorInitializer("dev")._factory();
}
