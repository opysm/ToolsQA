using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsQA.UI.Pages;

namespace ToolsQA.UI
{
	public static class ToolsQAPages
	{
		public static IndexPage IndexPage => new IndexPage();
		public static SearchPage SearchPage => new SearchPage();
		public static SignInPage SignInPage => new SignInPage();
		public static CreateAccountPage CreateAccountPage => new CreateAccountPage();
		public static OrderPage OrderPage => new OrderPage();
	}
}
