namespace Testbed.Traps.TrapJsonOptionsOverloads;

using System;
using System.Text.Json;

public class TrapJsonOptionsOverloads
{
    public string Serialize(object value) => JsonSerializer.Serialize(value, new JsonSerializerOptions());

    public string SerializeNamed(object value) => JsonSerializer.Serialize(value, options: new JsonSerializerOptions());

    public T? Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions());

    public object? DeserializeAs(string json, Type type) => JsonSerializer.Deserialize(json, type, new JsonSerializerOptions());

    public static string Run() => new TrapJsonOptionsOverloads().Serialize(new { A = 1 }) + new TrapJsonOptionsOverloads().Deserialize<int>("2");
}
