namespace Testbed.EditorConfig.EditorConfigIDE0301IDE0302IDE0303IDE0304IDE0305CollectionExpressions;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

public class EditorConfigIDE0301IDE0302IDE0303IDE0304IDE0305CollectionExpressions
{
    public static string Run()
    {
        int[] empty = Array.Empty<int>();
        ImmutableArray<int> created = ImmutableArray.Create(1, 2);
        Span<int> stacked = stackalloc int[] { 1, 2 };
        int[] source = { 3, 4 };
        List<int> copy = source.ToList();
        var builder = ImmutableArray.CreateBuilder<int>();
        builder.Add(1);
        ImmutableArray<int> built = builder.ToImmutable();

        return (empty.Length + created.Length + stacked.Length + copy.Count + built.Length).ToString();
    }
}
