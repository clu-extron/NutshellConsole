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
            CalculateAsync();
            Console.Read();
        }

        static async void CalculateAsync()
        {
            var result1 = await Calculate1Async();
            var result2 = await Calculate2Async(result1);
            var result = await Calculate3Async(result1, result2);
            Console.WriteLine(result);
        }

        static async Task<int> Calculate1Async()
        {
            var result = 3;
            Console.WriteLine($"Calculate1； {result}");
            await Task.Delay(3000);
            return result;
        }

        static async Task<int> Calculate2Async(int a)
        {
            var result = a + 3;
            Console.WriteLine($"Calculate2； {result}");
            await Task.Delay(2000);
            return result;
        }

        static async Task<int> Calculate3Async(int a, int b)
        {
            var result = a + b;
            Console.WriteLine($"Calculate3； {result}");
            await Task.Delay(1000);
            return result;
        }
    }
}