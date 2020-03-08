using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsQA.Framework;

namespace ToolsQA.UI.Page
{
    public class SignInPage
    {
		#region Page Mapping

		private IWebElement EmailCreateField => DriverFactory.Get().FindElement(By.Id("email_create"));
		private IWebElement CreateAccountButton => DriverFactory.Get().FindElement(By.Id("SubmitCreate"));

		#endregion Page Mapping

		#region Page Objects

		public void SetNewEmail(String text)
		{
			EmailCreateField.SendKeys(text);
		}

		public void CreateAccount()
		{
			CreateAccountButton.Click();
		}

		#endregion Page Objects
	}
}
