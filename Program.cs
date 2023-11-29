using NutshellConsole.Ch7;
using System.Collections;

static Dictionary<int, Customer> GetCustomersDictionary(int count)
{
    var customers = new Dictionary<int, Customer>();
    for (int i = 0; i < count; i++)
    {
        customers.Add(i, new Customer(i, $"Alex{i}", $"Location{i}"));
    }
    return customers;
}

static Hashtable GetCustomersHashTable(int count)
{
    var customers = new Hashtable();
    for (int i = 0; i < count; i++)
    {
        customers.Add(i, new Customer(i, $"Alex{i}", $"Location{i}"));
    }
    return customers;
}

//var customers = GetCustomersDictionary(1000000);
//var target = customers[99999];
//Console.WriteLine($"Customer ID {target.Id}, Customer Name: {target.Name}");

// HashTable
var customers = GetCustomersHashTable(1000000);
var target = (Customer)customers[99999];
Console.WriteLine($"Customer ID {target.Id}, Customer Name: {target.Name}");

Console.Read();