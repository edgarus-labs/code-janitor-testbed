namespace Testbed.Settings.SealClassesWhenSafe;

internal class Animal
{
    public virtual string Name => "animal";
}

internal class Dog : Animal
{
    public override string Name => "dog";
}

public class SealClassesWhenSafe
{
    public static string Run() => new Dog().Name;
}
