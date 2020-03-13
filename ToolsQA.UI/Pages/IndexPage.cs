using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsQA.Framework;

namespace ToolsQA.UI.Pages
{
	public class IndexPage
	{
		#region Page Mapping

		private IWebElement SearchField => DriverFactory.Get().FindElement(By.Id("search_query_top"));
		private IWebElement SearchButton => DriverFactory.Get().FindElement(By.Name("submit_search"));
		private IWebElement SignInLink => DriverFactory.Get().FindElement(By.ClassName("login"));

		#endregion Page Mapping

		#region Page Objects

		public void SetSearchText(String text)
		{
			SearchField.SendKeys(text);
		}

		public string GetSearchText()
		{
			return SearchField.Text;
		}

		public string SearchText {
			get { return SearchField.Text; }
			set { SearchField.SendKeys(value); }
		}

		public void ClickSearch()
		{
			SearchButton.Click();
		}

		public void OpenSignInPage()
		{
			SignInLink.Click();
		}

		#endregion Page Objects
	}
}
