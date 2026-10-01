namespace Testbed.CodeStyle.CsharpStyleExpressionBodiedOperators;

public struct Vector
{
    public int X;

    public static Vector operator -(Vector left, Vector right) => new Vector { X = left.X - right.X };
}

public class CsharpStyleExpressionBodiedOperators
{
    public static string Run() => (new Vector { X = 5 } - new Vector { X = 2 }).X.ToString();
}
