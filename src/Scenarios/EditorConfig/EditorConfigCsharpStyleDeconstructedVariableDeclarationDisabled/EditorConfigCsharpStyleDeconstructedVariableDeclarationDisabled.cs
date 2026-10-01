namespace Testbed.EditorConfig.EditorConfigCsharpStyleDeconstructedVariableDeclarationDisabled;

public class EditorConfigCsharpStyleDeconstructedVariableDeclarationDisabled
{
    public int Deconstruct()
    {
        var point = (x: 1, y: 2);

        return point.x + point.y;
    }

    public static string Run() => new EditorConfigCsharpStyleDeconstructedVariableDeclarationDisabled().Deconstruct().ToString();
}
