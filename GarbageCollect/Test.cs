using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutshellConsole.GarbageCollect
{
    public class Test
    {
        public Test()
        {
            Console.WriteLine("Test class created");
        }

        ~Test()
        {
            Console.WriteLine("Test class destroyed");
        }
    }
}
