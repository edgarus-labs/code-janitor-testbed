namespace Testbed.Traps.TrapSealedGenericConstraint;

public class TrapSealedGenericConstraint
{
    public class Constraint
    {
        public string Name => "c";
    }

    public class Holder<T> where T : Constraint
    {
        public T? Value { get; set; }
    }

    public static string Run() => new Holder<Constraint> { Value = new Constraint() }.Value!.Name;
}
