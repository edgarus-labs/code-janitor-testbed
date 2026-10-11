namespace Testbed.Settings.CommentFormatXmlAlignParamTags;

public class CommentFormatXmlAlignParamTags
{
    /// <summary>
    /// Joins two values.
    /// </summary>
    /// <param name="a">The first value.</param>
    /// <param name="longer">The second value.</param>
    /// <returns>The joined values.</returns>
    public static string Join(string a, string longer) => a + longer;

    public static string Run()
    {
        return Join("aligned", "");
    }
}
