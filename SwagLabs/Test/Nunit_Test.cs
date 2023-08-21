using System;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SwagLabs.Pages;
using SwagLabs.Utilities;

namespace SwagLabs.Test
{
    [TestFixture]
    public class Nunit_Test : CommonDriver

	{
		
		[SetUp]
		public void SetUPSL()
		{
			// Open the Browser
			driver = new ChromeDriver();


            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginAction(driver);
			Thread.Sleep(1000);

            Homepage homepageobj = new Homepage();
            homepageobj.GoToHomepageaction(driver);

        }
        [Test]
        public void AppLogoElement()
        {
            // Find the App Logo element on the webpage
            IWebElement logoElement = driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[1]/div[2]/div"));

            //Assert that the app logo element is displayed
            Assert.IsTrue(logoElement.Displayed);
        }
        [Test]
		public void AddToCart()
		{
			AllItemPage allItemObj = new AllItemPage();
			allItemObj.addToCartAction(driver);
			Thread.Sleep(2000);
		}
		[Test]
		public void RemoveItem_Test()
		{
			AllItemPage allItemObj = new AllItemPage();
			allItemObj.removeToCartAction(driver);
		}

		[TearDown]
		public void CloseTestRun()
		{
			driver.Close();
		}
	}
}

