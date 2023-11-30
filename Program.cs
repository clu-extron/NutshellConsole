CancellationTokenSource tokenSource = new CancellationTokenSource();

Thread thread = new Thread(PrintHello);
thread.Start();

//// 将主线程和子线程绑定起来, 主线程会被挂起,
//// 等待子线程执行完毕后, 主线程会接收到子线程执行完毕的通知, 继续执行
//thread.Join();

bool check = true;
while (check)
{
    if (thread.IsAlive)
    {
        Console.WriteLine("child tread RUNNING");
        Thread.Sleep(100);
    }
    else
    {
        Console.WriteLine("child thread COMPLETE");
        check = false;
    }
}


Console.WriteLine("Exit Main Program");

void PrintHello(object obj)
{
    int i = 0;
    while (i++ < 10)
    {
        Thread.Sleep(new Random().Next(100, 1000));
        Console.WriteLine("Hello from PrintHello");
    }
}