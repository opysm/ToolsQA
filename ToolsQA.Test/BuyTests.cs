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
    class BuyTests
    {
        [SetUp]
        public void SetUp()
        {
            string url = "http://automationpractice.com/index.php";
            string eMail = "testmail000@gmail.com";
            string password = "Qwerty123!@#";

            DriverFactory.Initialize(url);
            DriverFactory.Get().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            ToolsQAPages.IndexPage.OpenSignInPage();
            ToolsQAPages.SignInPage.SetRegisteredEmail(eMail);
            ToolsQAPages.SignInPage.SetPassword(password);
            ToolsQAPages.SignInPage.SignIn();
            DriverFactory.Get().Url = url;
        }

        [Test]
        public void BuyFirstProductTest(){
            string searchText = "Printed";

            ToolsQAPages.IndexPage.SetSearchText(searchText);
            ToolsQAPages.IndexPage.ClickSearch();
            ToolsQAPages.SearchPage.FirstProductAddToCart();
            ToolsQAPages.SearchPage.ProceedToCheckout();
            ToolsQAPages.OrderPage.ProceedToCheckout();
            ToolsQAPages.OrderPage.ProceedToCheckoutAddress();
            ToolsQAPages.OrderPage.SetAgreeCheckbox();
            ToolsQAPages.OrderPage.ProceedToCheckoutCarrier();
            ToolsQAPages.OrderPage.PayByBankWire();
            ToolsQAPages.OrderPage.Confirm();

            var actualOrderStatus = ToolsQAPages.OrderPage.GetOrderStatus();
            var expectedOrderStatus = "Your order on My Store is complete.";

            Assert.AreEqual(expectedOrderStatus, actualOrderStatus);
        }


        [TearDown]
        public void TearDown()
        {
            DriverFactory.Get().Close();
        }
    }
}
