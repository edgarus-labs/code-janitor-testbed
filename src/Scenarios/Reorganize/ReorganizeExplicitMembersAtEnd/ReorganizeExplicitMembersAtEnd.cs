namespace Testbed.Reorganize.ReorganizeExplicitMembersAtEnd;

using System;

public class ReorganizeExplicitMembersAtEnd : IDisposable
{
    void IDisposable.Dispose() { }

    public static string Run() => "ok";

    public int Count { get; set; }
}
