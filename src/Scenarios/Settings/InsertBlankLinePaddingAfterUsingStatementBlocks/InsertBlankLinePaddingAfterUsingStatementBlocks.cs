#nullable enable
using System;
using System.Text;
namespace Testbed.Settings.InsertBlankLinePaddingAfterUsingStatementBlocks
{
    public class InsertBlankLinePaddingAfterUsingStatementBlocks
    {
        public static string Run() => new StringBuilder().Append(Math.Abs(-1)).ToString();
    }
}
