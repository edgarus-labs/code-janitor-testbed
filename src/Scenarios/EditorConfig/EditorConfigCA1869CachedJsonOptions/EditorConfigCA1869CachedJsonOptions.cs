namespace Testbed.EditorConfig.EditorConfigCA1869CachedJsonOptions;

using System.Text.Json;

public class EditorConfigCA1869CachedJsonOptions
{
    public static string Run() => JsonSerializer.Serialize(new { A = 1 }, new JsonSerializerOptions { WriteIndented = true });
}
