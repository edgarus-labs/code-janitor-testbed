namespace Testbed.Traps.TrapAccessModifiersOnSpecialMembers;

using System;

public class TrapAccessModifiersOnSpecialMembers
{
    private static readonly string s_name;

    static TrapAccessModifiersOnSpecialMembers()
    {
        s_name = "init";
    }

    ~TrapAccessModifiersOnSpecialMembers()
    {
    }

    private sealed class Resource : IDisposable
    {
        void IDisposable.Dispose()
        {
        }
    }

    public static string Run()
    {
        IDisposable resource = new Resource();
        resource.Dispose();

        return s_name;
    }
}
