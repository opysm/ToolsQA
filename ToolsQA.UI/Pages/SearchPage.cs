using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsQA.Framework;

namespace ToolsQA.UI.Page
{
    public class SearchPage
    {
		#region Page Mapping

		private IWebElement SearchWarning => DriverFactory.Get().FindElement(By.ClassName("alert-warning"));
		private IReadOnlyCollection<IWebElement> products => DriverFactory.Get().FindElements(By.XPath("//div[@class='product-container']"));
		private IWebElement FirstProductName => DriverFactory.Get().FindElement(By.XPath("//div[@class='product-container']/div/h5/a"));
		private IWebElement FirstProductPrice => DriverFactory.Get().FindElement(By.XPath("(//span[@class='price product-price'])[2]"));

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

		#endregion Page Objects
	}
}
