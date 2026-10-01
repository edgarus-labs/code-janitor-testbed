namespace Testbed.CodeStyle.DotnetStylePredefinedTypeForLocalsParametersMembers;

using System;

public class DotnetStylePredefinedTypeForLocalsParametersMembers
{
    public Int32 Number(String text, Boolean flag)
    {
        Int32 length = text.Length;

        return flag ? length : 0;
    }

    public static string Run() => new DotnetStylePredefinedTypeForLocalsParametersMembers().Number("abc", true).ToString();
}
