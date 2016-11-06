using System.Collections.Generic;
using TechLibrary.Interfaces;

namespace TechLibrary.Data.Entities
{ 
    public class Section
    {
        public Section(string name, int order)
        {
            Name = name;
            Order = order;
        }

        public List<IContentElement> ContentElements { get; } = new List<IContentElement>();

        public void AddContentElement(string name, int order)
        {
            var ce = new ContentElement(name);
            ContentElements.Add(ce);
        }

        public string Name { get; }
        public int Order { get; }
    }
}
