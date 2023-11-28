using NutshellConsole.Ch7;

var bank = new Bank();

foreach (var c in bank)
{
    Console.WriteLine(c.Name);
}