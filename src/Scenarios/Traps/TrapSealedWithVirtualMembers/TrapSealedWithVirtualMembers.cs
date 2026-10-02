namespace Testbed.Traps.TrapSealedWithVirtualMembers;

public class TrapSealedWithVirtualMembers
{
    public static string Run() => new Leaf().Name + new Outer().Value;

    public class Outer
    {
        public virtual int Value => 1;
    }

    public class Leaf
    {
        protected string Hidden => "h";

        public string Name => Hidden;
    }
}
