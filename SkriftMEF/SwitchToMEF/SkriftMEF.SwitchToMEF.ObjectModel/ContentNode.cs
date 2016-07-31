namespace SkriftMEF.SwitchToMEF.ObjectModel
{
    public class ContentNode
    {
        public ContentNode(string name, string documentType)
        {
            Name = name;
            DocumentType = documentType;
        }
        public string Name { get; private set; }
        public string DocumentType { get; private set; }
    }
}
