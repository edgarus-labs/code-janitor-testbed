namespace Testbed.EditorConfig.EditorConfigSeparateImportDirectiveGroups;

using Microsoft.CSharp.RuntimeBinder;
using System.Text;
using System;

public class EditorConfigSeparateImportDirectiveGroups
{
    public static string Run() => new StringBuilder().Append(Math.Abs(-1)).ToString() + typeof(RuntimeBinderException).Name.Length;
}
