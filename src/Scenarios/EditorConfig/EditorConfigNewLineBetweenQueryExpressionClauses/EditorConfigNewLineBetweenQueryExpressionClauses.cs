namespace Testbed.EditorConfig.EditorConfigNewLineBetweenQueryExpressionClauses;

using System.Linq;

public class EditorConfigNewLineBetweenQueryExpressionClauses
{
    public static string Run()
    {
        var query = from item in new[] { 1, 2, 3 } where item > 1
            select item * 2;

        return string.Concat(query);
    }
}
