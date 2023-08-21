using System;
using OpenQA.Selenium;

namespace SwagLabs.Pages
{
    public class LoginPage
	{
		public void LoginAction(IWebDriver driver)
		{
			driver.Manage().Window.Maximize();

			//Launch SwagLabs Portal and Navigate to Login Page
			driver.Navigate().GoToUrl("https://www.saucedemo.com/");

			//Identify Username textbox and enter the valid username
			IWebElement usernametextbox = driver.FindElement(By.Id("user-name"));
			usernametextbox.SendKeys("standard_user");


			//Identify Password textbox and enter the valid password
			IWebElement passwordtextbox = driver.FindElement(By.Id("password"));
			passwordtextbox.SendKeys("secret_sauce");

			//Identify Login Button and click
			IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"login-button\"]"));
			loginButton.Click();
           
        }
    }
}

