using System.Runtime.CompilerServices;
using NutshellConsole.LearnLinq;

List<Car> cars = ProcessCars("C:/Learn/Files/CSV/fuel.csv");

//var query = cars
//    .OrderByDescending(c => c.Combined)
//    .ThenByDescending(c => c.Model);

var query = (from car in cars
    where car.Manufacturer == "BMW" && car.Year == "2016"
    orderby car.Combined descending, car.Model descending
    select new
    {
        Model = car.Model,
        Combined = car.Combined
    }).FirstOrDefault();

//foreach (var c in query.Take(10))
//{
//    Console.WriteLine($"{c.Model} {c.Combined}");
//}

Console.WriteLine($"{query?.Model} {query?.Combined}");

Console.WriteLine("*************************************");
Console.WriteLine("*************************************");

// Any()
var query2 = cars.Any(c => c.Manufacturer == "Volkswagen");
Console.WriteLine(query2);

List<Car> ProcessCars(string v)
{
    var result = File.ReadAllLines(v)
        .Skip(1)
        .Where(l => l.Length > 1)
        .ToCar();
        //.Select(line =>
        //{
        //    var columns = line.Split(",");
        //    return new Car
        //    {
        //        Year = columns[0],
        //        Manufacturer = columns[1],
        //        Model = columns[2],
        //        Displacement = double.Parse(columns[3]),
        //        CylindersCount = int.Parse(columns[4]),
        //        City = int.Parse(columns[5]),
        //        Highway = int.Parse(columns[6]),
        //        Combined = int.Parse(columns[7])
        //    };
        //});

    return result.ToList();
}

Console.WriteLine("*************************************");
Console.WriteLine("*************************************");

// SelectMany
var query3 = cars.Select(c => c.Model);
foreach (var c in query3)
{
    Console.WriteLine(c); 
}

Console.Read();