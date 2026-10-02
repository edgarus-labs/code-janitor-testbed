namespace Testbed.CodeStyle.CsharpStyleThrowExpression;

using System;

public class CsharpStyleThrowExpression
{
    private readonly string _name;

    public CsharpStyleThrowExpression(string name)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        _name = name;
    }

    public static string Run() => new CsharpStyleThrowExpression("abc")._name;
}
