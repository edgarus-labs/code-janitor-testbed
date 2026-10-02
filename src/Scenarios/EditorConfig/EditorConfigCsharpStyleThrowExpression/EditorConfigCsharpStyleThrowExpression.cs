namespace Testbed.EditorConfig.EditorConfigCsharpStyleThrowExpression;

using System;

public class EditorConfigCsharpStyleThrowExpression
{
    private readonly string _name;

    public EditorConfigCsharpStyleThrowExpression(string name)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        _name = name;
    }

    public static string Run() => new EditorConfigCsharpStyleThrowExpression("abc")._name;
}
