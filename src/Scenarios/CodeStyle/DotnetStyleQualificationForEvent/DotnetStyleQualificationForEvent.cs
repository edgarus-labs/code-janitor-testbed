namespace Testbed.CodeStyle.DotnetStyleQualificationForEvent;

using System;

public class DotnetStyleQualificationForEvent
{
    public event EventHandler? Changed;

    public int Raised;

    public void Raise()
    {
        this.Changed?.Invoke(this, EventArgs.Empty);
    }

    public static string Run()
    {
        var instance = new DotnetStyleQualificationForEvent();
        instance.Changed += (_, _) => instance.Raised++;
        instance.Raise();

        return instance.Raised.ToString();
    }
}
