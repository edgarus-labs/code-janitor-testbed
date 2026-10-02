namespace Testbed.EditorConfig.EditorConfigCsharpStyleConditionalDelegateCallDisabled;

using System;

public class EditorConfigCsharpStyleConditionalDelegateCallDisabled
{
    private Action? _callback;

    public int Calls;

    public void Raise()
    {
        if (_callback != null)
        {
            _callback();
        }
    }

    public static string Run()
    {
        var instance = new EditorConfigCsharpStyleConditionalDelegateCallDisabled();
        instance._callback = () => instance.Calls++;
        instance.Raise();

        return instance.Calls.ToString();
    }
}
