using System.Diagnostics;

namespace NutshellConsole
{
    class Program
    {
        /// <summary>
        /// 异步不是多线程，异步用于处理Parallelism，多线程用于处理Concurrency Task vs. Thread
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //TaskTest();
            //ThreadTest();
            DoSomething();
            Console.WriteLine("Main Program End");
        }

        static void DoSomething()
        {
            Console.WriteLine("Async task begins!");
            Task.Delay(60000).Wait();
            Console.WriteLine("Async task ends");
        }

        static void TaskTest()
        {
            var sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < 100; i++)
            {
                Task.Factory.StartNew(() => { });
            }

            sw.Stop();
            Console.WriteLine($"Task {sw.ElapsedMilliseconds}");
        }

        static void ThreadTest()
        {
            var sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < 100; i++)
            {
                new Thread(() => { }).Start();
            }

            sw.Stop();
            Console.WriteLine($"Thread {sw.ElapsedMilliseconds}");
        }
    }
}