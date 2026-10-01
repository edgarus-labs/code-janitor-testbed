namespace Testbed.EditorConfig.EditorConfigInlinedVariableDeclaration;

public class EditorConfigInlinedVariableDeclaration
{
    public static string Run()
    {
        int number;
        if (int.TryParse("12", out number))
        {
            return number.ToString();
        }

        return "none";
    }
}
