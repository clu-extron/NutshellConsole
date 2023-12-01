using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutshellConsole.GarbageCollect
{
    public class SubTest2 : SubTest1
    {
        public SubTest2()
        {
            Console.WriteLine("SubTest2 class created");
        }

        ~SubTest2()
        {
            Console.WriteLine("SubTest2 class destroyed");
        }
    }
}
