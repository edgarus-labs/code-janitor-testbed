using System;

namespace Testbed.Usings.UsingsInwardSkippedWithSeveralNamespaces.First
{
    public class FirstType
    {
    }
}

namespace Testbed.Usings.UsingsInwardSkippedWithSeveralNamespaces
{
    public class UsingsInwardSkippedWithSeveralNamespaces
    {
        public static string Run() => Math.Abs(-1).ToString();
    }
}
