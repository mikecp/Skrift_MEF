using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkriftMEF.Logging.Interface;

namespace SkriftMEF.Logging.MailLogger
{
    [Export(typeof (ILogger))] // <== this class exposes the ILogger interface for composition
    public class Log2Mail : ILogger
    {
        private int _minErrorLevel = 4;

        // ILogger interface implementation
        public string Name
        {
            get { return "Email Logger"; }
        }

        public void Log(int level, string message)
        {
            // If the error level exceeds a specified threshold, we send an email
            if (level > _minErrorLevel)
            {
                // Do some stuff to send an email
                Console.WriteLine("Sending an email with following info: {0} - {1}", level, message);
            }
        }
    }
}
