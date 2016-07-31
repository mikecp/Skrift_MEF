using System.Collections.Generic;
using SkriftMEF.SwitchToMEF.ObjectModel;

namespace SkriftMEF.SwitchToMEF.Interface
{
    public interface IMyCRUDOperations
    {
        IEnumerable<string> SupportedDocTypes { get; }
        void Create(ContentNode node);
        void Update(ContentNode node);
        void Delete(ContentNode node);
    }
}
