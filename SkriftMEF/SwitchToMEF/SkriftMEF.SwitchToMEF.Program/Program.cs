using System;
using SkriftMEF.SwitchToMEF.ObjectModel;

namespace SkriftMEF.SwitchToMEF.Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var nodes = new ContentNode[]
            {
                new ContentNode("node 1", "DocType1"),
                new ContentNode("node 25", "DocType25"),
                new ContentNode("node 26", "DocType26"),
                new ContentNode("node 28", "DocType28"),
                new ContentNode("node 29", "DocType29"),
                new ContentNode("node 40", "DocType40")
            };

            var crudSample = new CRUDSample();
            
            foreach (var contentNode in nodes)
            {
                crudSample.Create(contentNode);
            }

            Console.ReadLine();
        }
    }
}
