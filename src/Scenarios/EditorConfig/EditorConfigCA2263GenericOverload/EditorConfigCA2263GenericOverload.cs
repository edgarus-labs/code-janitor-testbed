namespace Testbed.EditorConfig.EditorConfigCA2263GenericOverload;

using System.Runtime.InteropServices;

public class EditorConfigCA2263GenericOverload
{
    public static string Run() => Marshal.SizeOf(typeof(int)).ToString();
}
