using System.Collections.Generic;
using System.ComponentModel.Composition;
using SkriftMEF.SwitchToMEF.DAL;
using SkriftMEF.SwitchToMEF.Interface;
using SkriftMEF.SwitchToMEF.ObjectModel;

namespace SkriftMEF.SwitchToMEF.Variations
{
    [Export(typeof(IMyCRUDOperations))] // <== we expose the IMyCRUDOperations interface for composition
    public class MyCRUDOperationsVariation3 : IMyCRUDOperations
    {
        private IEnumerable<string> _supportedDocTypes = new[] { "DocType27", "DocType28" };
        private MyCustomDAL _myCustomDAL = new MyCustomDAL(); // some custom data access layer	

        // Implementation of the IMyCRUDOperations interface
        public IEnumerable<string> SupportedDocTypes { get { return _supportedDocTypes; } } // <== This implementaiton supports only doc types 27 and 28

        public void Create(ContentNode node)
        {
            _myCustomDAL.CreateMethod3(node);
        }
        public void Update(ContentNode node)
        {
            _myCustomDAL.UpdateMethod3(node);
        }

        public void Delete(ContentNode node)
        {
            _myCustomDAL.DeleteMethod3(node);
        }
    }

}
