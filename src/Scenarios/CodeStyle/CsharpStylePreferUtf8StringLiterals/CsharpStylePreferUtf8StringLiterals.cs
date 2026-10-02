namespace Testbed.CodeStyle.CsharpStylePreferUtf8StringLiterals;

public class CsharpStylePreferUtf8StringLiterals
{
    public byte[] Bytes()
    {
        return new byte[] { 104, 101, 108, 108, 111 };
    }

    public static string Run() => new CsharpStylePreferUtf8StringLiterals().Bytes().Length.ToString();
}
