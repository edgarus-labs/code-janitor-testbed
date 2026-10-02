namespace Testbed.Traps.TrapTextRulesInsideStringLiterals;

public class TrapTextRulesInsideStringLiterals
{
    public static string Run()
    {
        var verbatim = @"first   


   second
	tabbed";
        var raw = """
            keep   


            this
            """;

        return verbatim + raw;
    }
}
