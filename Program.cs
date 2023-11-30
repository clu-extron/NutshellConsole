Thread thread = new Thread(() =>
{
    Print1();
});
thread.Start();

for (int i=0; i<1000; i++)
{
    Console.Write(0);
}

static void Print1()
{
    for (int i = 0; i < 1000; i++)
    {
        Console.Write(1);
    }
}

Console.Read();