namespace Testbed.CodeStyle.CsharpPreferSimpleUsingStatement;

using System.IO;

public class CsharpPreferSimpleUsingStatement
{
    public int FirstByte()
    {
        using (var stream = new MemoryStream(new byte[] { 7 }))
        {
            return stream.ReadByte();
        }
    }

    public static string Run() => new CsharpPreferSimpleUsingStatement().FirstByte().ToString();
}
