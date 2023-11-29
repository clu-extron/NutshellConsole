using NutshellConsole.Ch7;

static IEnumerable<Customer> GetCustomers(int count)
{
    var customers = new List<Customer>();
    for (int i = 0; i < count; i++)
    {
        customers.Add(new Customer(i, $"Alex{i}", $"Location{i}"));
    }
    return customers;
}

static IEnumerable<Customer> GetCustomersYield(int count)
{
    for (int i = 0; i < count; i++)
    {
        yield return new Customer(i, $"Alex{i}", $"Location{i}");
    }
}

//var customers = GetCustomers(1000000);
//foreach (var c in customers)
//{
//    if (c.Id < 1000)
//    {
//        Console.WriteLine($"Customer ID {c.Id}, Customer Name: {c.Name}");
//    }
//    else
//    {
//        break;
//    }
//}

//var customers = GetCustomersYield(1000000);
//foreach (var c in customers)
//{
//    if (c.Id < 3)
//    {
//        Console.WriteLine($"Customer ID {c.Id}, Customer Name: {c.Name}");
//    }
//    else
//    {
//        break;
//    }
//}

static IEnumerable<int> CreatEnumerable()
{
    yield return 3;
    yield return 2;
    yield return 1;
}

foreach (var item in CreatEnumerable())
{
    Console.WriteLine(item);
}