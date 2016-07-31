using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using SkriftMEF.Logging.Interface;

namespace SkriftMEF.Logging.MyProgram
{
    public class LoggingSample
    {
        [ImportMany(typeof(ILogger))] // <== this variable will hold a composition of all classes implementing the ILogger interface. 
        IEnumerable<ILogger> _myLoggers;

        public LoggingSample()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(@".\\"));  // root is the bin directory
            catalog.Catalogs.Add(new DirectoryCatalog(@"..\\..\\LoggingPlugins")); // add a specific directory

            CompositionContainer _container = new CompositionContainer(catalog);

            try
            {
                _container.ComposeParts(this); // <== this will add into the _myLoggers variable an instance of each class implementing ILogger that can be found in the folders contained in the composer catalog
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }

        // Method called by the main program
        public void DoSomeTests()
        {
            MyNotCriticalMethod();
            Console.WriteLine();
            MySuperCriticalMethod();
        }

        public void MyNotCriticalMethod()
        {
            try
            {
                Console.WriteLine("Doing some not critical logic");

                // Some non-critical logic happens here

                throw new Exception("Something non critical went wrong");
            }
            catch (Exception e)
            {
                LogException(1, e); // <== this is a low importance problem
            }
        }

        public void MySuperCriticalMethod()
        {
            try
            {
                Console.WriteLine("Doing some very critical logic");

                // Some very critical logic happens here

                throw new Exception("Something very critical went wrong");
            }
            catch (Exception e)
            {
                LogException(10, e); // <== this is really a critical issue!
            }
        }

        // Helper class for the logging
        private void LogException(int level, Exception e)
        {
            Console.WriteLine("Something went wrong");
            foreach (var logger in _myLoggers)
                logger.Log(level, e.Message);
        }
    }
}
