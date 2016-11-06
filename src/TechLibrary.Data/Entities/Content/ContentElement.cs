using System;
using TechLibrary.Interfaces;

namespace TechLibrary.Data.Entities
{
    public class ContentElement : IContentElement
    {
        public ContentElement(string name)
        {
            Name = name;
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }

        public string Name { get; }

        public int Version { get; set; }

        public IContentElement Content { get; set; }

    }
}
