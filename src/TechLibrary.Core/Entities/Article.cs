﻿using System;
using System.Collections.Generic;
using TechLibrary.Domain.Values;

namespace TechLibrary.Domain.Entities
{
    public class Article
    {
        public Article(Guid id)
        {
            ID = id;
        }

        public Guid ID { get;  }

        public List<Section>  Sections { get; } = new List<Section>();

        public void AddSection(string name, int order)
        {
            var section   = new Section(name, order);
            Sections.Add(section);
        }
    }
}
