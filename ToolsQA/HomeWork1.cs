using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToolsQA
{
	[TestFixture]
	public class HomeWork1
	{
		private IWebDriver driver;

		[SetUp]
		public void SetUp()
		{
			driver = new ChromeDriver();
			driver.Url = "https://demoqa.com/automation-practice-form/";
			driver.Manage().Window.Maximize(); //Why window maximizes after link is opened?
		}

		[Test]
		public void OpenLinkTest()
		{
			var destinationPage = "https://www.toolsqa.com/automation-practice-table/";

			var link = driver.FindElement(By.LinkText("Link Test"));
			link.Click();
			Assert.AreEqual(destinationPage, driver.Url);

		}

		[Test]
		public void SubmitNameTest()
		{
			var firstNameField = driver.FindElement(By.Name("firstname"));
			var lastNameField = driver.FindElement(By.Id("lastname"));
			var submitButton = driver.FindElement(By.Id("buttonwithclass"));
			firstNameField.SendKeys("fName");
			lastNameField.SendKeys("lName");

			submitButton.Click();

			firstNameField.SendKeys("ddddddddddddddddddddddddd");//StaleElementReferenceException: element is not attached to the page document
			var fAtribute = firstNameField.GetAttribute("value");
			Assert.IsNotEmpty(fAtribute);
		}

		[Test]
		public void RadiobuttonsTest()
		{
			var sex = driver.FindElement(By.Id("sex-0"));
			var experience0 = driver.FindElement(By.Id("exp-0"));
			var experience1 = driver.FindElement(By.Id("exp-1"));

			sex.Click();
			experience0.Click();

			Assert.IsTrue(sex.Selected);
			Assert.IsTrue(experience0.Selected);
			Assert.IsFalse(experience1.Selected);
		}

		[Test]
		public void CheckboxesTest()
		{
			var manualField = driver.FindElement(By.Id("tool-0"));
			manualField.Click();
			Assert.IsTrue(manualField.Selected);
		}

		[Test]
		public void DropdownTest()
		{
			var continentElement = driver.FindElement(By.Id("continents"));
			var continentMultElement = driver.FindElement(By.Id("continentsmultiple"));

			SelectElement select = new SelectElement(continentElement);
			SelectElement multiSelect = new SelectElement(continentMultElement);

			select.SelectByValue("EU");

			multiSelect.SelectByValue("AS");
			multiSelect.SelectByValue("EU");
		}

		[Test]
		public void ChildElementTest()
		{
			var list = driver.FindElement(By.XPath("//*[@id='beverages']/child::li[1]"));
			Assert.AreEqual("Coffee", list.GetAttribute("value")); //Isn't value Coffee?

		}

		[Test]
		public void DateTest()
		{
			var dateField = driver.FindElement(By.Id("datepicker"));
			dateField.SendKeys(DateTime.Today.ToString());
			var setDate = dateField.GetAttribute("value");
			Assert.AreEqual(DateTime.Today.ToString(), setDate);
		}

		[Test]
		public void AttachmentsTest()
		{

			var filePicker = driver.FindElement(By.Id("photo"));
			filePicker.SendKeys("D://File.txt");
			Assert.IsNotEmpty(filePicker.GetAttribute("value"));
		}


		[TearDown]
		public void TearDown()
		{
			driver.Close();
		}

		private void AcceptCookie()
		{
			var acceptCookieButton = driver.FindElement(By.Id("cookie_action_close_header"));
			acceptCookieButton.Click();
		}
	}
}
