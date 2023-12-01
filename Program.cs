namespace NutshellConsole
{
    class Program
    {
        /// <summary>
        /// 我们用异步来处理并行，用多线程来处理并发。异步的性能会比多线程高出不少
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Calculate();
            Console.Read();
        }

        static void Calculate()
        {
            // Task -> 异步
            // Thread -> 线程
            //Calculate1();
            //Calculate2();
            //Calculate3();

            var task1 = Task.Run(() =>
            {
                return Calculate1();
            });
            var task2 = Task.Run(() =>
            {
                return Calculate2();
            });

            Task.WaitAll(task1, task2);

            var awaiter1 = task1.GetAwaiter();
            var awaiter2 = task2.GetAwaiter();

            var result1 = awaiter1.GetResult();
            var result2 = awaiter2.GetResult();

            var result = Calculate3(result1, result2);
            Console.WriteLine(result);
        }

        static int Calculate1()
        {
            var result = 3;
            Console.WriteLine($"Calculate1； {result}");
            Thread.Sleep(2000);
            return result;
        }

        static int Calculate2()
        {
            var result = 4;
            Console.WriteLine($"Calculate2； {result}");
            Thread.Sleep(3000);
            return result;
        }

        static int Calculate3(int a, int b)
        {
            var result = a + b;
            Console.WriteLine($"Calculate3； {result}");
            Thread.Sleep(1000);
            return result;
        }
    }
}