using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SwagLabs.Pages
{
	public class Homepage
	{
        public void GoToHomepageaction(IWebDriver driver)
		{

            Thread.Sleep(1000);
            IWebElement burgerMenu = driver.FindElement(By.Id("react-burger-menu-btn"));
            burgerMenu.Click();
        }
        //public void VerifyHomepageLabel(IWebDriver driver)
       // {
           
       // }

    }
}

