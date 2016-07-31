using System.Collections.Generic;
using System.ComponentModel.Composition;
using SkriftMEF.SwitchToMEF.DAL;
using SkriftMEF.SwitchToMEF.Interface;
using SkriftMEF.SwitchToMEF.ObjectModel;

namespace SkriftMEF.SwitchToMEF.Variations
{
    [Export(typeof(IMyCRUDOperations))] // <== we expose the IMyCRUDOperations interface for composition
    public class MyCRUDOperationsVariation4 : IMyCRUDOperations
    {
        private IEnumerable<string> _supportedDocTypes = new[] { "DocType29", /* ... ,*/ "DocType40" };
        private MyCustomDAL _myCustomDAL = new MyCustomDAL(); // some custom data access layer	

        // Implementation of the IMyCRUDOperations interface
        public IEnumerable<string> SupportedDocTypes { get { return _supportedDocTypes; } } // <== This implementaiton supports doc types 29 to 40

        public void Create(ContentNode node)
        {
            _myCustomDAL.CreateMethod4(node);
        }
        public void Update(ContentNode node)
        {
            _myCustomDAL.UpdateMethod4(node);
        }

        public void Delete(ContentNode node)
        {
            _myCustomDAL.DeleteMethod4(node);
        }
    }

}
