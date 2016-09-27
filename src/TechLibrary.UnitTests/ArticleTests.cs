using System;
using Moq;
using TechLibrary.Domain.Entities;
using Xunit;


namespace TechLibrary.UnitTests
{
    public class ArticleTests : TestBase
    {
        [Fact]
        public void AddSectionToArticle()
        {
            var article = GetArticle();
            article.AddSection(It.IsAny<string>(), It.IsAny<int>());
            Assert.Equal(1, article.Sections.Count);
        }


        public void AddContentToSection()
        {
            var article = GetArticle();


        }






    }
}
