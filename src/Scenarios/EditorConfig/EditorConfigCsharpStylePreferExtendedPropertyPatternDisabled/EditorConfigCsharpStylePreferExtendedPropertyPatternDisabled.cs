namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferExtendedPropertyPatternDisabled;

public class Address
{
    public int Zip { get; set; }
}

public class Customer
{
    public Address? Address { get; set; }
}

public class EditorConfigCsharpStylePreferExtendedPropertyPatternDisabled
{
    public bool InZip(Customer customer)
    {
        return customer is { Address: { Zip: 100 } };
    }

    public static string Run() => new EditorConfigCsharpStylePreferExtendedPropertyPatternDisabled().InZip(new Customer { Address = new Address { Zip = 100 } }).ToString();
}
