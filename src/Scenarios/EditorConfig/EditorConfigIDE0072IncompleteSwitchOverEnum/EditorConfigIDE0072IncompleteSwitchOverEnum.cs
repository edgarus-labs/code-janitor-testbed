namespace Testbed.EditorConfig.EditorConfigIDE0072IncompleteSwitchOverEnum;

public class EditorConfigIDE0072IncompleteSwitchOverEnum
{
    public enum Color
    {
        Red,
        Green,
        Blue,
    }

    private static string Name(Color color) => color switch
    {
        Color.Red => "red",
        Color.Green => "green",
    };

    public static string Run() => Name(Color.Red);
}
