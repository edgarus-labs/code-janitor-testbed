namespace Testbed.Settings.ReuseJsonSerializerOptionsForCA1869;

using System.Text.Json;

public class ReuseJsonSerializerOptionsForCA1869
{
    public static string Run() => JsonSerializer.Serialize(new { A = 1 }, new JsonSerializerOptions());
}
