namespace Testbed.CodeStyle.CsharpStyleDeconstructedVariableDeclaration;

public class CsharpStyleDeconstructedVariableDeclaration
{
    public int Deconstruct()
    {
        var point = (x: 1, y: 2);

        return point.x + point.y;
    }

    public static string Run() => new CsharpStyleDeconstructedVariableDeclaration().Deconstruct().ToString();
}
