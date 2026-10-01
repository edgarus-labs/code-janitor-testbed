namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferUtf8StringLiteralsDisabled;

public class EditorConfigCsharpStylePreferUtf8StringLiteralsDisabled
{
    public byte[] Bytes()
    {
        return new byte[] { 104, 101, 108, 108, 111 };
    }

    public static string Run() => new EditorConfigCsharpStylePreferUtf8StringLiteralsDisabled().Bytes().Length.ToString();
}
