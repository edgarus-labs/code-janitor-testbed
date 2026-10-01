namespace Testbed.EditorConfig.EditorConfigCsharpStyleDeconstructedVariableDeclaration;

public class EditorConfigCsharpStyleDeconstructedVariableDeclaration
{
    public int Deconstruct()
    {
        var point = (x: 1, y: 2);

        return point.x + point.y;
    }

    public static string Run() => new EditorConfigCsharpStyleDeconstructedVariableDeclaration().Deconstruct().ToString();
}
