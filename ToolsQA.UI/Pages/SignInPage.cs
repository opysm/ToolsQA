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
		private IWebElement EmailRegisteredField => DriverFactory.Get().FindElement(By.Id("email"));
		private IWebElement PasswordField => DriverFactory.Get().FindElement(By.Id("passwd"));
		private IWebElement SignInButton => DriverFactory.Get().FindElement(By.Id("SubmitLogin"));

		#endregion Page Mapping

		#region Page Objects

		public void SetNewEmail(String eMail)
		{
			EmailCreateField.SendKeys(eMail);
		}

		public void CreateAccount()
		{
			CreateAccountButton.Click();
		}

		public void SetRegisteredEmail(string eMail)
		{
			EmailRegisteredField.SendKeys(eMail);
		}

		public void SetPassword(string password)
		{
			PasswordField.SendKeys(password);
		}

		public void SignIn()
		{
			SignInButton.Click();
		}

		#endregion Page Objects
	}
}
