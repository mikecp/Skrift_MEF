using System;
using System.ComponentModel.Composition;
using SkriftMEF.Logging.Interface;

namespace SkriftMEF.Logging.FileLogger
{
    [Export(typeof (ILogger))] // <== this class exposes the ILogger interface for composition
    public class Log2File : ILogger
    {
        // ILogger interface implementation
        public string Name
        {
            get { return "File Logger"; }
        }

        public void Log(int level, string message)
        {
            // Do some stuff
            Console.WriteLine("Logging following info to file: {0} - {1}", level, message);
        }
    }

}
