using NutshellConsole.Ch7;
using NutshellConsole.LearnLinq;

var customers = new List<Customer>
{
    new Customer(1, "Andrew", "EastVale"),
    new Customer(2, "Greg", "Corona"),
    new Customer(3, "Jimmy", "Sherman Oaks"),
    new Customer(4, "Mark", "Burbank"),
    new Customer(5, "Boris", "Fremont"),
    new Customer(6, "Eric", "EastVale"),
    new Customer(7, "Kate", "EastVale")
};

var query = customers
    .MyWhere(c => c.Address == "EastVale")
    .OrderBy(c => c.Name);

foreach (var c in query)
{
    Console.WriteLine($"Customer: {c.Id}, {c.Name}, {c.Address}");
}

Console.Read();