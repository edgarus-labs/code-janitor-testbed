namespace Testbed.EditorConfig.EditorConfigDotnetStylePredefinedTypeForLocalsParametersMembers;

using System;

public class EditorConfigDotnetStylePredefinedTypeForLocalsParametersMembers
{
    public Int32 Number(String text, Boolean flag)
    {
        Int32 length = text.Length;

        return flag ? length : 0;
    }

    public static string Run() => new EditorConfigDotnetStylePredefinedTypeForLocalsParametersMembers().Number("abc", true).ToString();
}
