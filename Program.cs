CancellationTokenSource tokenSource = new CancellationTokenSource();

Thread thread = new Thread(()=>
{
    PrintHello(tokenSource.Token);
});
thread.Start();

// Mock Download File
Thread.Sleep(5000);

// Shut down child thread
tokenSource.Cancel();
Console.WriteLine("Exit Main Program");

void PrintHello(CancellationToken token)
{
    while (!token.IsCancellationRequested)
    {
        Thread.Sleep(1000);
        Console.WriteLine("Hello from PrintHello");
    }
}