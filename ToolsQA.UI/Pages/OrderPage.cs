using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsQA.Framework;

namespace ToolsQA.UI.Pages
{
	public class OrderPage
    {
		#region Page Mapping

		private IWebElement ProceedToCheckoutButton => DriverFactory.Get().FindElement(By.XPath("(//a[@title='Proceed to checkout'])[2]"));
		private IWebElement ProceedToCheckoutAddressButton => DriverFactory.Get().FindElement(By.Name("processAddress"));
		private IWebElement AgreeCheckbox => DriverFactory.Get().FindElement(By.Name("cgv"));
		private IWebElement ProceedToCheckoutCarrierButton => DriverFactory.Get().FindElement(By.Name("processCarrier"));
		private IWebElement PayByBankWireLink => DriverFactory.Get().FindElement(By.XPath("//a[@title='Pay by bank wire']"));
		private IWebElement ConfirmButton => DriverFactory.Get().FindElement(By.XPath("//button[@class='button btn btn-default button-medium']"));
		private IWebElement OrderStatusText => DriverFactory.Get().FindElement(By.XPath("//p[@class='cheque-indent']/strong"));

		#endregion Page Mapping

		#region Page Objects

		public void ProceedToCheckout()
		{
			ProceedToCheckoutButton.Click();
		}

		public void ProceedToCheckoutAddress()
		{
			ProceedToCheckoutAddressButton.Click();
		}


		public void SetAgreeCheckbox()
		{
			AgreeCheckbox.Click();
		}

		public void ProceedToCheckoutCarrier()
		{
			ProceedToCheckoutCarrierButton.Click();
		}

		public void PayByBankWire()
		{
			PayByBankWireLink.Click();
		}

		public void Confirm()
		{
			ConfirmButton.Click();
		}

		public string GetOrderStatus()
		{
			return OrderStatusText.Text;
		}

		#endregion Page Objects
	}
}
