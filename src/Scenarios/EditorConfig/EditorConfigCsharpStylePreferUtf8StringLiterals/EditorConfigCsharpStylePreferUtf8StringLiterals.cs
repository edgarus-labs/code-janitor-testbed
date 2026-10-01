namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferUtf8StringLiterals;

public class EditorConfigCsharpStylePreferUtf8StringLiterals
{
    public byte[] Bytes()
    {
        return new byte[] { 104, 101, 108, 108, 111 };
    }

    public static string Run() => new EditorConfigCsharpStylePreferUtf8StringLiterals().Bytes().Length.ToString();
}
