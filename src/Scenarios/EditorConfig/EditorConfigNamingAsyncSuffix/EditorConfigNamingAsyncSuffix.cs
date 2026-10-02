namespace Testbed.EditorConfig.EditorConfigNamingAsyncSuffix;

using System.Threading.Tasks;

public class EditorConfigNamingAsyncSuffix
{
    private static async Task<int> Load()
    {
        await Task.Yield();

        return 1;
    }

    public static string Run() => Load().GetAwaiter().GetResult().ToString();
}
