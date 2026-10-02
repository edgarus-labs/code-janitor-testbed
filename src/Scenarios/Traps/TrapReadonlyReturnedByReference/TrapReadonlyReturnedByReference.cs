namespace Testbed.Traps.TrapReadonlyReturnedByReference;

public class TrapReadonlyReturnedByReference
{
    private int _slot = 1;

    public ref int Slot() => ref _slot;

    public static string Run()
    {
        var instance = new TrapReadonlyReturnedByReference();
        instance.Slot() = 5;

        return instance._slot.ToString();
    }
}
