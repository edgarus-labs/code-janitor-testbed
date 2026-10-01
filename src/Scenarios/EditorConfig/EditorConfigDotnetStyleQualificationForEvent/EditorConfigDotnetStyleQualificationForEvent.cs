namespace Testbed.EditorConfig.EditorConfigDotnetStyleQualificationForEvent;

using System;

public class EditorConfigDotnetStyleQualificationForEvent
{
    public event EventHandler? Changed;

    public int Raised;

    public void Raise()
    {
        this.Changed?.Invoke(this, EventArgs.Empty);
    }

    public static string Run()
    {
        var instance = new EditorConfigDotnetStyleQualificationForEvent();
        instance.Changed += (_, _) => instance.Raised++;
        instance.Raise();

        return instance.Raised.ToString();
    }
}
