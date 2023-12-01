using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutshellConsole.GarbageCollect
{
    public class SubTest1 : Test
    {
        public SubTest1()
        {
            Console.WriteLine("SubTest1 class created");
        }

        ~SubTest1()
        {
            Console.WriteLine("SubTest1 class destroyed");
        }
    }
}
