using System;
using Microsoft.VisualStudio.CodeCoverage;
using OpenQA.Selenium;

namespace SwagLabs.Pages
{
	public class AllItemPage
	{
		public void addToCartAction(IWebDriver driver)
		{
			IWebElement addToCart = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
			addToCart.Click();
            Thread.Sleep(1000);

            //Identify Shopping Cart link and click on it
            IWebElement shoppingCart = driver.FindElement(By.XPath("//*[@id=\"shopping_cart_container\"]/a"));
            shoppingCart.Click();

            //Identify remove item button and click on it
            IWebElement removeToCart = driver.FindElement(By.Id("remove-sauce-labs-backpack"));
            removeToCart.Click();

            //Identify Continueshoppingbutton and click on it
            IWebElement continueShopping = driver.FindElement(By.Id("continue-shopping"));
            continueShopping.Click();

        }
		
       public void removeToCartAction(IWebDriver driver)
       {
           
           IWebElement removeToCart = driver.FindElement(By.XPath("//*[@id=\"continue-shopping\"]"));
           removeToCart.Click();

        }

        
    }
}
