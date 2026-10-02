namespace Testbed.EditorConfig.EditorConfigCA1834AppendChar;

public class EditorConfigCA1834AppendChar
{
    public static string Run()
    {
        var builder = new System.Text.StringBuilder();
        builder.Append("x");

        return builder.ToString();
    }
}
