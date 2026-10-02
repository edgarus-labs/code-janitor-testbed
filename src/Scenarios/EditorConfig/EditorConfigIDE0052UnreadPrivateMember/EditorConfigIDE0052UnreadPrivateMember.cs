namespace Testbed.EditorConfig.EditorConfigIDE0052UnreadPrivateMember;

public class EditorConfigIDE0052UnreadPrivateMember
{
    private int _unread;

    public void Set() => _unread = 1;

    public static string Run()
    {
        new EditorConfigIDE0052UnreadPrivateMember().Set();

        return "ok";
    }
}
