using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsQA.Framework;

namespace ToolsQA.UI.Pages
{
	public class CreateAccountPage
	{
		#region Page Mapping

		private IWebElement MrRadiobutton => DriverFactory.Get().FindElement(By.Id("id_gender1"));
		private IWebElement FNameField => DriverFactory.Get().FindElement(By.Id("customer_firstname"));
		private IWebElement LNameField => DriverFactory.Get().FindElement(By.Id("customer_lastname"));
		private IWebElement EmailField => DriverFactory.Get().FindElement(By.Id("email"));
		private IWebElement PasswordField => DriverFactory.Get().FindElement(By.Id("passwd"));
		private IWebElement DaySelector => DriverFactory.Get().FindElement(By.Id("days"));
		private IWebElement MonthSelector => DriverFactory.Get().FindElement(By.Id("months"));
		private IWebElement YearSelector => DriverFactory.Get().FindElement(By.Id("years"));

		private IWebElement AddressField => DriverFactory.Get().FindElement(By.Id("address1"));
		private IWebElement CityField => DriverFactory.Get().FindElement(By.Id("city"));
		private IWebElement StateSelector => DriverFactory.Get().FindElement(By.Id("id_state"));
		private IWebElement ZipCodeField => DriverFactory.Get().FindElement(By.Id("postcode"));
		private IWebElement MobilePhoneField => DriverFactory.Get().FindElement(By.Id("phone_mobile"));

		private IWebElement RegisterButton => DriverFactory.Get().FindElement(By.Id("submitAccount"));
		
		#endregion Page Mapping

		#region Page Objects

		public void SetGenderMr()
		{
			MrRadiobutton.Click();
		}

		public void SetFirstName(string fName)
		{
			FNameField.SendKeys(fName);
		}

		public void SetLastName(string lName)
		{
			LNameField.SendKeys(lName);
		}

		public string GetEmail()
		{
			return EmailField.GetAttribute("value");
		}

		public void SetPassword(string password)
		{
			PasswordField.SendKeys(password);
		}

		public void SetDateOfBirth(DateTime dateOfBirth)
		{
			new SelectElement(DaySelector).SelectByValue(dateOfBirth.Day.ToString());
			new SelectElement(MonthSelector).SelectByValue(dateOfBirth.Month.ToString());
			new SelectElement(YearSelector).SelectByValue(dateOfBirth.Year.ToString());
		}

		public void SetAddress(string address)
		{
			AddressField.SendKeys(address);
		}

		public void SetCity(string city)
		{
			CityField.SendKeys(city);
		}

		public void SetState(string stateID)
		{
			new SelectElement(StateSelector).SelectByValue(stateID);
		}

		public void SetZipCode(string code)
		{
			ZipCodeField.SendKeys(code);
		}

		public void SetMobilePhone (string phone)
		{
			MobilePhoneField.SendKeys(phone);
		}

		public void CreateAccount()
		{
			RegisterButton.Click();
		}
		#endregion Page Objects
	}
}
