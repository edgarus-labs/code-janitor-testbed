namespace Testbed.Traps.TrapNullCheckOverloadedEquality;

public class TrapNullCheckOverloadedEquality
{
    public sealed class Money
    {
        public int Cents;

        public static bool operator ==(Money? left, Money? right) => left?.Cents == right?.Cents || (left is null && right is null);

        public static bool operator !=(Money? left, Money? right) => !(left == right);

        public override bool Equals(object? obj) => obj is Money other && other.Cents == Cents;

        public override int GetHashCode() => Cents;
    }

    public static string Run()
    {
        Money? none = null;
        var empty = new Money { Cents = 0 };

        return (none == null) + "," + (empty == null) + "," + (empty != null);
    }
}
