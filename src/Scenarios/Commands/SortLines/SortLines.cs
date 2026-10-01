using System.Text;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Testbed.Commands.SortLines;

public class SortLines
{
    public static string Run() => new StringBuilder().Append(new List<int>().Count).Append(Math.Abs(-1)).Append(new[] { 1 }.Count()).ToString();
}
