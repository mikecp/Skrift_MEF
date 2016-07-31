using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using SkriftMEF.SwitchToMEF.Interface;
using SkriftMEF.SwitchToMEF.ObjectModel;

namespace SkriftMEF.SwitchToMEF.Program
{
    public class CRUDSample
    {
        [ImportMany(typeof(IMyCRUDOperations))]  // <== This variable will hold a composition list
        IEnumerable<IMyCRUDOperations> _myCRUDVariations;

        public CRUDSample()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(@".\\"));  // root is the bin directory
            catalog.Catalogs.Add(new DirectoryCatalog(@"..\\..\\CRUDVariations")); // add a specific directory

            CompositionContainer _container = new CompositionContainer(catalog);

            try
            {
                _container.ComposeParts(this); // <== this will add into the _myCRUDVariations variable an instance of each class implementing IMyCRUDOperations that can be found in the folders accessed by the composer (default: bin)
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }

        public void Create(ContentNode node)
        {
            // Those few lines of code replace the whole switch statement
            var curDocType = node.DocumentType; // In Umbraco world, this would be a different call to get the doc type of your node
            var curVariation = _myCRUDVariations.FirstOrDefault(variation => variation.SupportedDocTypes.Contains(curDocType));  // search for the variation handling this node's document type
            if (curVariation == null)
                Console.WriteLine("ERROR : No CRUD variation found for document type " + curDocType);
            else
                curVariation.Create(node);
        }
    }
}
