namespace Testbed.EditorConfig.EditorConfigNamingTypeParametersBeginWithT;

public class EditorConfigNamingTypeParametersBeginWithT
{
    private static Item Echo<Item>(Item value) => value;

    public static string Run() => Echo(4).ToString();
}
