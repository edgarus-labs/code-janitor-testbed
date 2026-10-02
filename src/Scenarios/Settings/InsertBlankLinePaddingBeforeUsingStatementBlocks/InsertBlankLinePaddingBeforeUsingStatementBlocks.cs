#nullable enable
using System;
using System.Text;
namespace Testbed.Settings.InsertBlankLinePaddingBeforeUsingStatementBlocks
{
    public class InsertBlankLinePaddingBeforeUsingStatementBlocks
    {
        public static string Run() => new StringBuilder().Append(Math.Abs(-1)).ToString();
    }
}
