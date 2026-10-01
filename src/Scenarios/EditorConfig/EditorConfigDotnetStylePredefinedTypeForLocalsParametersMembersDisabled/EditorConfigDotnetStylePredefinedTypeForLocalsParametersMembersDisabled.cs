namespace Testbed.EditorConfig.EditorConfigDotnetStylePredefinedTypeForLocalsParametersMembersDisabled;

using System;

public class EditorConfigDotnetStylePredefinedTypeForLocalsParametersMembersDisabled
{
    public Int32 Number(String text, Boolean flag)
    {
        Int32 length = text.Length;

        return flag ? length : 0;
    }

    public static string Run() => new EditorConfigDotnetStylePredefinedTypeForLocalsParametersMembersDisabled().Number("abc", true).ToString();
}
