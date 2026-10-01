namespace Testbed.Usings.UsingsOutwardSkippedInsideConditionalCompilation
{
#if NET10_0_OR_GREATER
    using System.Text;
#endif

    public class UsingsOutwardSkippedInsideConditionalCompilation
    {
        public static string Run() => "ok";
    }
}
