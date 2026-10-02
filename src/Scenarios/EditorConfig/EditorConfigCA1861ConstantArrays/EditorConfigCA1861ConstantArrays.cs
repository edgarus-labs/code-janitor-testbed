namespace Testbed.EditorConfig.EditorConfigCA1861ConstantArrays;

public class EditorConfigCA1861ConstantArrays
{
    public static string Run()
    {
        var parts = "a,b;c".Split(new[] { ',', ';' });

        return parts.Length.ToString();
    }
}
