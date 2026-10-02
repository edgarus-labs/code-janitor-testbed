namespace Testbed.EditorConfig.EditorConfigCsharpStyleExpressionBodiedOperatorsTrue;

public class EditorConfigCsharpStyleExpressionBodiedOperatorsTrue
{
    public struct Vector
    {
        public int X;

        public static Vector operator -(Vector left, Vector right)
        {
            return new Vector { X = left.X - right.X };
        }
    }

    public static string Run() => (new Vector { X = 5 } - new Vector { X = 2 }).X.ToString();
}
