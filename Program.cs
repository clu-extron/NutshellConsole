using NutshellConsole.LearnLinq;
using System.Linq;

string path = @"c:\windows";
ShowLargestFiles(path);
Console.WriteLine("******************************************");
Console.WriteLine("******************************************");
ShowLargestFilesWithLinq(path);

void ShowLargestFiles(string path)
{
    DirectoryInfo directory = new DirectoryInfo(path);
    FileInfo[] files = directory.GetFiles();
    Array.Sort(files, new FileInfoComparer());

    //foreach (var f in files)
    //{
    //    Console.WriteLine($"{f.Name, -20} : {f.Length, 10:N}");
    //}

    for (int i = 0; i < 5; i++)
    {
        var f = files[i];
        Console.WriteLine($"{f.Name,-20} : {f.Length,10:N}");
    }
}

void ShowLargestFilesWithLinq(string path)
{
    //var query = from file in new DirectoryInfo(path).GetFiles() 
    //            orderby file.Length descending 
    //            select file;

    //foreach (var f in query.Take(5))
    //{
    //    Console.WriteLine($"{f.Name,-20} : {f.Length,10:N}");
    //}

    // Linq + Lambda
    var query = new DirectoryInfo(path).GetFiles()
        .OrderByDescending(f => f.Length)
        .Take(5);

    foreach (var f in query)
    {
        Console.WriteLine($"{f.Name,-20} : {f.Length,10:N}");
    }
}

Console.Read();