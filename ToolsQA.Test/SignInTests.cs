using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
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
	class SignInTests
	{
		[SetUp]
		public void SetUp()
		{
			DriverFactory.Initialize("http://automationpractice.com/index.php");
			ToolsQAPages.IndexPage.OpenSignInPage();
			DriverFactory.Get().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
		}

		[Test]
		public void CreateAccountTest()
		{
			string eMail = $"testmail{DateTime.Now.Ticks}@gmail.com";
			
			string firstName = "James";
			string lastName = "Bakh";
			string password = "Qwerty123!@#";
			DateTime dateOfBirth = new DateTime(1966, 01, 01);
			string address = "In the middle of nowhere";
			string city = "Selenium City";
			string state = "2";
			string code = "77777";
			string phone = "0971234567";
			string successTitle = "My account - My Store";

			ToolsQAPages.SignInPage.SetNewEmail(eMail);
			ToolsQAPages.SignInPage.CreateAccount();

			ToolsQAPages.CreateAccountPage.SetGenderMr();
			ToolsQAPages.CreateAccountPage.SetFirstName(firstName);
			ToolsQAPages.CreateAccountPage.SetLastName(lastName);
			ToolsQAPages.CreateAccountPage.SetPassword(password);
			ToolsQAPages.CreateAccountPage.SetDateOfBirth(dateOfBirth);
			ToolsQAPages.CreateAccountPage.SetAddress(address);
			ToolsQAPages.CreateAccountPage.SetCity(city);
			ToolsQAPages.CreateAccountPage.SetState(state);
			ToolsQAPages.CreateAccountPage.SetZipCode(code);
			ToolsQAPages.CreateAccountPage.SetMobilePhone(phone);
			ToolsQAPages.CreateAccountPage.CreateAccount();
			
			Assert.AreEqual(successTitle, DriverFactory.Get().Title);
		}

		[Test]
		public void LogInTest()
		{
			string eMail = "testmail000@gmail.com";
			string password = "Qwerty123!@#";
			string successTitle = "My account - My Store";

			ToolsQAPages.SignInPage.SetRegisteredEmail(eMail);
			ToolsQAPages.SignInPage.SetPassword(password);
			ToolsQAPages.SignInPage.SignIn();

			Assert.AreEqual(successTitle, DriverFactory.Get().Title);
		}

		[TearDown]
		public void TearDown()
		{
			DriverFactory.Get().Close();
		}
	}
}
