using System;
using TechLibrary.Interfaces;

namespace TechLibrary.Domain.Entities
{
    public class ContentElement
    {
        public ContentElement(string name)
        {
            Name = name;
            ID = Guid.NewGuid();
        }

        public Guid ID { get; }

        public string Name { get; }

        public int Version { get; set; }

        public IContentElement Content { get; set; }

    }
}
