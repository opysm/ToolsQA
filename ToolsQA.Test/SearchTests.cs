using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            DriverFactory.Get().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void SearchFirstProductTest()
        {
            string searchText = "Printed";
            string expectedFirstProductName = "Printed Summer Dress";
            string expectedFirstProductPrice = "$28.98";

            ToolsQAPages.IndexPage.SetSearchText(searchText);
            ToolsQAPages.IndexPage.ClickSearch();
            
            var firstProductName = ToolsQAPages.SearchPage.GetFirstProductName();
            var firstProductPrice = ToolsQAPages.SearchPage.GetFirstProductPrice();
            
            Assert.AreEqual(expectedFirstProductName, firstProductName);
            Assert.AreEqual(expectedFirstProductPrice, firstProductPrice);
        }

        [Test]
        public void ProductQuantityTest()
        {
            string searchText = "Printed";
            int expectedProductQuantity = 5;

            ToolsQAPages.IndexPage.SetSearchText(searchText);
            ToolsQAPages.IndexPage.ClickSearch();
            var productQuantity = ToolsQAPages.SearchPage.GetProductQuantity();

            Assert.AreEqual(expectedProductQuantity, productQuantity);
        }

        [Test]
        public void SearchIncorrectTextTest()
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
