namespace Testbed.EditorConfig.EditorConfigAllowBlankLineAfterColonInConstructorInitializer;

public class EditorConfigAllowBlankLineAfterColonInConstructorInitializer
{
    private readonly int _value;

    public EditorConfigAllowBlankLineAfterColonInConstructorInitializer(int value) : this()
    {
        _value = value;
    }

    public EditorConfigAllowBlankLineAfterColonInConstructorInitializer() :

        base()
    {
    }

    public static string Run() => new EditorConfigAllowBlankLineAfterColonInConstructorInitializer(3)._value.ToString();
}
