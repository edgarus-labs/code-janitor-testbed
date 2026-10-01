namespace Testbed.EditorConfig.EditorConfigMA0048FileNameMatchesType;

public class EditorConfigMA0048FileNameMatchesType
{
    public static string Run() => MatchLevel.High.ToString() + typeof(IMatchMarker).Name;
}

public enum MatchLevel
{
    Low,
    High,
}

public interface IMatchMarker
{
}
