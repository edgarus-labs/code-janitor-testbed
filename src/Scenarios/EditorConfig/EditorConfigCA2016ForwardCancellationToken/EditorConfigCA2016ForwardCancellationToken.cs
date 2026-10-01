namespace Testbed.EditorConfig.EditorConfigCA2016ForwardCancellationToken;

using System.Threading;
using System.Threading.Tasks;

public class EditorConfigCA2016ForwardCancellationToken
{
    private static async Task<string> Wait(CancellationToken token)
    {
        await Task.Delay(1);

        return "ok";
    }

    public static string Run() => Wait(CancellationToken.None).GetAwaiter().GetResult();
}
