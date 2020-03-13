using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ToolsQA.Framework;

namespace ToolsQA.UI.Pages
{
    public class SearchPage
    {
		#region Page Mapping

		private IWebElement SearchWarning => DriverFactory.Get().FindElement(By.ClassName("alert-warning"));
		private IReadOnlyCollection<IWebElement> products => DriverFactory.Get().FindElements(By.XPath("//div[@class='product-container']"));
		private IWebElement FirstProductContainer => DriverFactory.Get().FindElement(By.ClassName("product-container"));
		private IWebElement FirstProductName => DriverFactory.Get().FindElement(By.XPath("//div[@class='product-container']/div/h5/a"));
		private IWebElement FirstProductPrice => DriverFactory.Get().FindElement(By.XPath("(//span[@class='price product-price'])[2]"));
		private IWebElement FirstProductAddToCartButton => DriverFactory.Get().FindElement(By.XPath("//a[@title='Add to cart']"));
		private IWebElement ProceedToCheckoutButton => DriverFactory.Get().FindElement(By.XPath("//a[@title='Proceed to checkout']"));

		#endregion Page Mapping

		#region Page Objects

		public string SearchText
		{
			get { return SearchWarning.Text; }
		}

		public int GetProductQuantity()
		{
			return products.Count;
		}

		public string GetFirstProductName()
		{
			return FirstProductName.Text;
		}

		public string GetFirstProductPrice()
		{
			return FirstProductPrice.Text;
		}

		public void FirstProductAddToCart()
		{
			Actions action = new Actions(DriverFactory.Get());
			action.MoveToElement(FirstProductContainer).Perform();
			FirstProductAddToCartButton.Click();
		}

		public void ProceedToCheckout()
		{
			ProceedToCheckoutButton.Click();
		}
		#endregion Page Objects
	}
}
