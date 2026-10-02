namespace Testbed.EditorConfig.EditorConfigDotnetStyleRequireAccessibilityModifiersForNonInterfaceMembers;

public class EditorConfigDotnetStyleRequireAccessibilityModifiersForNonInterfaceMembers
{
    int _value = 1;

    public interface IMarker
    {
        int Value { get; }
    }

    public static string Run() => new EditorConfigDotnetStyleRequireAccessibilityModifiersForNonInterfaceMembers()._value.ToString();
}
