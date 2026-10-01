namespace Testbed.EditorConfig.EditorConfigIDE0064ReadonlyFieldInMutableStruct;

public class EditorConfigIDE0064ReadonlyFieldInMutableStruct
{
    public struct Counter
    {
        private readonly int _value;

        public Counter(int value)
        {
            _value = value;
        }

        public void Reset() => this = default;

        public int Value => _value;
    }

    public static string Run() => new Counter(2).Value.ToString();
}
