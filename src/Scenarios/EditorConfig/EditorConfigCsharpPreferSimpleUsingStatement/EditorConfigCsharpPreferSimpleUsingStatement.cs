namespace Testbed.EditorConfig.EditorConfigCsharpPreferSimpleUsingStatement;

using System.IO;

public class EditorConfigCsharpPreferSimpleUsingStatement
{
    public int FirstByte()
    {
        using (var stream = new MemoryStream(new byte[] { 7 }))
        {
            return stream.ReadByte();
        }
    }

    public static string Run() => new EditorConfigCsharpPreferSimpleUsingStatement().FirstByte().ToString();
}
