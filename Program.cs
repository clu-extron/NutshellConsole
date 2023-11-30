using System.Runtime.CompilerServices;
using NutshellConsole.LearnLinq;

List<Car> cars = ProcessCars("C:/Learn/Files/CSV/fuel.csv");
List<Manufacturer> manufacturers = ProcessManufacturers("C:/Learn/Files/CSV/manufacturer.csv");

//var query = cars
//    .OrderByDescending(c => c.Combined)
//    .ThenByDescending(c => c.Model);

var query = (from car in cars
    join manufacturer in manufacturers on car.Manufacturer equals manufacturer.Name
    orderby car.Combined descending, car.Model descending
    select new
    {
        Manufacturer = car.Manufacturer,
        Model = car.Model,
        Combined = car.Combined,
        Headquarters = manufacturer.Headquarters,
        Phone = manufacturer.Phone
    })
    .Take(10);

var query2 = cars.Join(manufacturers, (c) => c.Manufacturer, m => m.Name, (c,m) => new
{
    Car = c,
    Manufacturer = m
}).OrderByDescending(joinData => joinData.Car.Combined)
    .ThenBy(joinData => joinData.Car.Model)
    .Select(joinData => new
    {
        Manufacturer = joinData.Car.Manufacturer,
        Model = joinData.Car.Model,
        Combined = joinData.Car.Combined,
        Headquarters = joinData.Manufacturer.Headquarters,
        Phone = joinData.Manufacturer.Phone
    }).Take(10);

foreach (var item in query)
{
    Console.WriteLine($"{item.Manufacturer} {item.Model} {item.Combined} {item.Headquarters} {item.Phone}");
}

Console.WriteLine("**************************************************************************************");
Console.WriteLine("**************************************************************************************");

foreach (var item in query2)
{
    Console.WriteLine($"{item.Manufacturer} {item.Model} {item.Combined} {item.Headquarters} {item.Phone}");
}

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