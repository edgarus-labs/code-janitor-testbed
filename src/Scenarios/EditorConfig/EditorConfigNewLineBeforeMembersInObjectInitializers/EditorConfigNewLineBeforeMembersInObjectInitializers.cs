namespace Testbed.EditorConfig.EditorConfigNewLineBeforeMembersInObjectInitializers;

using System.Linq;

public class EditorConfigNewLineBeforeMembersInObjectInitializers
{
    public static string Run()
    {
        var box = new Box { Width = 1,
            Height = 2 };

        return (box.Width + box.Height).ToString();
    }

    private class Box
    {
        public int Width { get; set; }

        public int Height { get; set; }
    }
}
