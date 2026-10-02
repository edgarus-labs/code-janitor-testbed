namespace Testbed.Usings.UsingsOutwardKeepsAliasAndStatic
{
    using static System.Math;
    using Builder = System.Text.StringBuilder;

    public class UsingsOutwardKeepsAliasAndStatic
    {
        public static string Run() => new Builder().Append(Abs(-3)).ToString();
    }
}
