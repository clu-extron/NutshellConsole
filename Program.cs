using System.Diagnostics;
using NutshellConsole.GarbageCollect;

namespace NutshellConsole
{
    class Program
    {
        /// <summary>
        /// 1.一个类只能有一个终结器。
        /// 2.不能继承或重载终结器。
        /// 3.不能手动调用终结器。
        /// 4.终结器不使用修饰符或参数。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DoSomething();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            Console.WriteLine("Program terminated.");
        }

        static void DoSomething()
        {
            new SubTest2();
        }
    }
}