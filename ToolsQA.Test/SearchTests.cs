using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsQA.Framework;
using ToolsQA.UI;

namespace ToolsQA.Test
{
    [TestFixture]
    public class SearchTests
    {
        [SetUp]
        public void SetUp()
        {
            DriverFactory.Initialize("http://automationpractice.com/index.php");
        }

        [Test]
        public void SearchIncorrectText()
        {
            string searchText = "aaaaaaaaaaaaa";
            string expectedSearchWarning = $"No results were found for your search \"{searchText}\"";

            ToolsQAPages.IndexPage.SetSearchText(searchText);
            ToolsQAPages.IndexPage.ClickSearch();

            var actualSearchText = ToolsQAPages.SearchPage.SearchText;
            Assert.AreEqual(expectedSearchWarning, actualSearchText);
        }

        [TearDown]
        public void TearDown()
        {
            DriverFactory.Get().Close();
        }
    }
}
