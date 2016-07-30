using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkriftMEF.Logging.Interface;

namespace SkriftMEF.Logging.MyProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            var test = new LoggingSample();
            Console.Clear();
            test.DoSomeTests();
            Console.Read();
        }
    }
}
