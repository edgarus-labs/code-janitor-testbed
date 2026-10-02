namespace Testbed.Traps.TrapReadonlyMutableStructField;

public class TrapReadonlyMutableStructField
{
    private struct Tally
    {
        private int _value;

        public void Increment() => _value++;

        public int Value => _value;
    }

    private Tally _tally = new Tally();
    private System.Threading.SpinLock _spin = new System.Threading.SpinLock();

    public int Bump()
    {
        _tally.Increment();
        var taken = false;
        _spin.Enter(ref taken);
        if (taken)
        {
            _spin.Exit();
        }

        return _tally.Value;
    }

    public static string Run() => new TrapReadonlyMutableStructField().Bump().ToString();
}
