using System.Collections.Generic;
using TechLibrary.Domain.Entities;

namespace TechLibrary.Domain.Values
{ 
    public class Section
    {
        public Section(string name, int order)
        {
            Name = name;
            Order = order;
        }

        public List<ContentElement> ContentElements { get; } = new List<ContentElement>();

        public void AddContentElement(string name, int order)
        {
            var ce = new ContentElement(name);
            ContentElements.Add(ce);
        }

        public string Name { get; }
        public int Order { get; }
    }
}
