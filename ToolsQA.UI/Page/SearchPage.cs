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

		#endregion Page Mapping

		#region Page Objects

		public string SearchText
		{
			get { return SearchWarning.Text; }
		}

		#endregion Page Objects
	}
}
