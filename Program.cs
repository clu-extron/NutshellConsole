Thread thread = new Thread(PrintHello);

// Switch to back-end thread
//thread.IsBackground = true;
thread.Start();

Console.WriteLine("End of Main Program");

void PrintHello(object? obj)
{
    while (true)
    {
        Thread.Sleep(1000);
        Console.WriteLine("Hello from PrintHello");
    }
}