namespace Testbed.EditorConfig.EditorConfigCsharpStyleConditionalDelegateCall;

using System;

public class EditorConfigCsharpStyleConditionalDelegateCall
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
        var instance = new EditorConfigCsharpStyleConditionalDelegateCall();
        instance._callback = () => instance.Calls++;
        instance.Raise();

        return instance.Calls.ToString();
    }
}
