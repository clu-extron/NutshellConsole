using System.Runtime.CompilerServices;
using NutshellConsole.LearnLinq;

List<Car> cars = ProcessCars("C:/Learn/Files/CSV/fuel.csv");
List<Manufacturer> manufacturers = ProcessManufacturers("C:/Learn/Files/CSV/manufacturer.csv");

var query = from car in cars
    group car by car.Manufacturer into manufacturerGroup 
    orderby manufacturerGroup.Key descending 
    select manufacturerGroup;

var query2 = cars.GroupBy(c => c.Manufacturer).OrderByDescending(g => g.Key);

foreach (var group in query)
{
    Console.WriteLine($"{group.Key} has {group.Count()} models of cars.");
    foreach (var car in group.OrderByDescending(c => c.Combined).Take(2))
    {
        Console.WriteLine($"\t {car.Model} {car.Combined}");
    }
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("***************************************************************************");

foreach (var group in query2)
{
    Console.WriteLine($"{group.Key} has {group.Count()} models of cars.");
    foreach (var car in group.OrderByDescending(c => c.Combined).Take(2))
    {
        Console.WriteLine($"\t {car.Model} {car.Combined}");
    }
}

List<Car> ProcessCars(string v)
{
    var result = File.ReadAllLines(v)
        .Skip(1)
        .Where(l => l.Length > 1)
        .ToCar();

    return result.ToList();
}

List<Manufacturer> ProcessManufacturers(string v)
{
    var result = File.ReadLines(v)
        .Skip(1)
        .Where(l => l.Length > 1)
        .Select(line =>
        {
            var columns = line.Split(",");
            return new Manufacturer
            {
                Name = columns[0],
                Headquarters = columns[1],
                Phone = columns[2]
            };
        });
    return result.ToList();
}

Console.Read();