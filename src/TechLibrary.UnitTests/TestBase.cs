using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechLibrary.Domain.Entities;

namespace TechLibrary.UnitTests
{
    public abstract class TestBase
    {
        protected Article GetArticle()
        {
            var mock = new Article(It.IsAny<Guid>());

            return mock;
        }
    }
}
