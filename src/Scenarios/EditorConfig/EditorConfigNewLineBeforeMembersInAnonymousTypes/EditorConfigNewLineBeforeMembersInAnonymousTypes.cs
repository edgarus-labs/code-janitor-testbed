namespace Testbed.EditorConfig.EditorConfigNewLineBeforeMembersInAnonymousTypes;

using System.Linq;

public class EditorConfigNewLineBeforeMembersInAnonymousTypes
{
    public static string Run()
    {
        var point = new { X = 1,
            Y = 2 };

        return (point.X + point.Y).ToString();
    }
}
