namespace Testbed.EditorConfig.EditorConfigCsharpPreferSimpleUsingStatementDisabled;

using System.IO;

public class EditorConfigCsharpPreferSimpleUsingStatementDisabled
{
    public int FirstByte()
    {
        using (var stream = new MemoryStream(new byte[] { 7 }))
        {
            return stream.ReadByte();
        }
    }

    public static string Run() => new EditorConfigCsharpPreferSimpleUsingStatementDisabled().FirstByte().ToString();
}
