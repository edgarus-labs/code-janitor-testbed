namespace Testbed.CodeStyle.DotnetStyleQualificationForMethod;

public class DotnetStyleQualificationForMethod
{
    private int _count = 1;
    private int Size { get; set; } = 2;

    public int Total()
    {
        return this._count + this.Size + this.Twice(_count);
    }

    private int Twice(int value)
    {
        return value * 2;
    }

    public static string Run() => new DotnetStyleQualificationForMethod().Total().ToString();
}
