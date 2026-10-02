namespace Testbed.Settings.ConvertStringFormatToInterpolation;

public class ConvertStringFormatToInterpolation
{
    public static string Run()
    {
        var count = 3;

        return string.Format("{0} items", count);
    }
}
