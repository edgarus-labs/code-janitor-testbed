namespace Testbed.EditorConfig.EditorConfigCsharpStyleThrowExpressionDisabled;

using System;

public class EditorConfigCsharpStyleThrowExpressionDisabled
{
    private readonly string _name;

    public EditorConfigCsharpStyleThrowExpressionDisabled(string name)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        _name = name;
    }

    public static string Run() => new EditorConfigCsharpStyleThrowExpressionDisabled("abc")._name;
}
