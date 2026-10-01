namespace Testbed.CodeStyle.CsharpStylePreferExtendedPropertyPattern;

public class Address
{
    public int Zip { get; set; }
}

public class Customer
{
    public Address? Address { get; set; }
}

public class CsharpStylePreferExtendedPropertyPattern
{
    public bool InZip(Customer customer)
    {
        return customer is { Address: { Zip: 100 } };
    }

    public static string Run() => new CsharpStylePreferExtendedPropertyPattern().InZip(new Customer { Address = new Address { Zip = 100 } }).ToString();
}
