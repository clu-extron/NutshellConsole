namespace NutshellConsole
{
    class Program
    {
        static object lockedObj = new object();

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                var thread = new Thread(AddText);
                thread.Start();
            }
        }

        static void AddText()
        {
            lock (lockedObj)
            {
                File.AppendAllText(@"C:\Learn\Files\Test\test.txt", $"START_{Thread.CurrentThread.ManagedThreadId} ");
                Thread.Sleep(100);
                File.AppendAllText(@"C:\Learn\Files\Test\test.txt", $"END_{Thread.CurrentThread.ManagedThreadId} ");
            }
        }
    }
}