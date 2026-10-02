namespace Testbed.Traps.TrapStaticLambdaWithExpression;

using System;
using System.Linq;

public class TrapStaticLambdaWithExpression
{
    public sealed record Snapshot(int Count, string Names, int[] Items);

    private Snapshot _state = new Snapshot(0, "", Array.Empty<int>());

    private void Apply(Func<Snapshot, Snapshot> change) => _state = change(_state);

    public Snapshot Update(int[] devices, int now)
    {
        var tracked = devices.Where(device => device > 0).ToArray();
        Apply(current => current with
        {
            Count = tracked.Any(item => item > 1) ? now : current.Count,
            Names = string.Join(",", devices.Select(item => item.ToString())),
            Items = tracked,
        });

        return _state;
    }

    public static string Run() => new TrapStaticLambdaWithExpression().Update(new[] { 1, 2 }, 9).Names;
}
