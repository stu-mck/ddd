using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechLibrary.Interfaces;

namespace TechLibrary.Domain.Entities
{
    public class TextContent : IContentElement
    {
        public TextContent(Guid id)
        {
            ID = id;
        }

        public Guid ID { get; set; }

    }
}
