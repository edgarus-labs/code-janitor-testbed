namespace Testbed.EditorConfig.EditorConfigDotnetStyleQualificationForEventTrue;

using System;

public class EditorConfigDotnetStyleQualificationForEventTrue
{
    public event EventHandler? Changed;

    public int Raised;

    public void Raise() => Changed?.Invoke(this, EventArgs.Empty);

    public static string Run()
    {
        var instance = new EditorConfigDotnetStyleQualificationForEventTrue();
        instance.Changed += (_, _) => instance.Raised++;
        instance.Raise();

        return instance.Raised.ToString();
    }
}
