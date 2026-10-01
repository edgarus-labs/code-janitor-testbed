namespace Testbed.Traps.TrapUsingAliasesAndStatic;

using static System.Math;
using Builder = System.Text.StringBuilder;
using System;
using System.Text;

public class TrapUsingAliasesAndStatic
{
    public static string Run() => new Builder().Append(Abs(-3)).Append(Max(1, 2)).ToString() + typeof(StringBuilder).Name.Length + Environment.NewLine.Length;
}
