int count = 0;
for (int i = 0; i < 100; i++)
{
    //var t = new Thread(() =>
    //{
    //    Console.WriteLine($"recycle times {i} thread id {Thread.CurrentThread.ManagedThreadId}");
    //});
    //t.Start();

    // Using Thread Pool
    ThreadPool.QueueUserWorkItem((o) =>
    {
        count++;
        Console.WriteLine($"Thread ID {Thread.CurrentThread.ManagedThreadId}");
    });
}

// Give the thread pool enough time to finish all the threads
//Thread.Sleep(5000);

Console.WriteLine($"End of Main Program, there are {count} threads in operation");