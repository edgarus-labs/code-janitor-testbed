namespace Testbed.Settings.MoveUsingsOutsideNamespace
{
    using System;
    using System.Text;

    public class MoveUsingsOutsideNamespace
    {
        public static string Run() => new StringBuilder().Append(Math.Abs(-2)).ToString();
    }
}
