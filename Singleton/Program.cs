using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.Instance;
            var log = Log.Instance;
            log.Save("a");
            log.Save("b");

            var a = Singleton.Instance;
            var b = Singleton.Instance;

            Console.WriteLine(a == b);

            Console.ReadKey();
        }
    }
}
