using NutshellConsole.Models;

namespace NutshellConsole
{
    internal class Program
    {
        /// <summary>
        /// Models: map data from our database to application (Source Mapping)
        /// Namespaces: Where the code lives
        /// Database Connection(Dapper & Entity Framework)
        /// Config: connections string
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Computer myComputer = new Computer()
            {
                Motherboard = "Z690",
                HasWifi = true,
                HasLTE = false,
                ReleaseDate = DateTime.Now,
                Price = 943.87m,
                VideoCard = "RTX 4060"
            };

            Console.WriteLine(myComputer.Motherboard);
            Console.WriteLine(myComputer.HasWifi);
            Console.WriteLine(myComputer.HasLTE);
            Console.WriteLine(myComputer.ReleaseDate);
            Console.WriteLine(myComputer.Price);
            Console.WriteLine(myComputer.VideoCard);
        }

    }
}