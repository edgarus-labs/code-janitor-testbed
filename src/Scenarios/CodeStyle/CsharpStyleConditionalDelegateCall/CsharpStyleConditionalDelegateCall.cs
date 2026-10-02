namespace Testbed.CodeStyle.CsharpStyleConditionalDelegateCall;

using System;

public class CsharpStyleConditionalDelegateCall
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
        var instance = new CsharpStyleConditionalDelegateCall();
        instance._callback = () => instance.Calls++;
        instance.Raise();

        return instance.Calls.ToString();
    }
}
