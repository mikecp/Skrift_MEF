using System.Collections.Generic;
using System.ComponentModel.Composition;
using SkriftMEF.SwitchToMEF.DAL;
using SkriftMEF.SwitchToMEF.Interface;
using SkriftMEF.SwitchToMEF.ObjectModel;

namespace SkriftMEF.SwitchToMEF.Variations
{
    [Export(typeof(IMyCRUDOperations))] // <== we expose the IMyCRUDOperations interface for composition
    public class MyCRUDOperationsVariation2 : IMyCRUDOperations
    {
        private IEnumerable<string> _supportedDocTypes = new[] {"DocType26"};
        private MyCustomDAL _myCustomDAL = new MyCustomDAL(); // some custom data access layer	

        // Implementation of the IMyCRUDOperations interface
        public IEnumerable<string> SupportedDocTypes { get { return _supportedDocTypes; } } // <== This implementaiton supports only doc type 26

        public void Create(ContentNode node)
        {
            _myCustomDAL.CreateMethod2(node);
        }
        public void Update(ContentNode node)
        {
            _myCustomDAL.UpdateMethod2(node);
        }

        public void Delete(ContentNode node)
        {
            _myCustomDAL.DeleteMethod2(node);
        }
    }

}
