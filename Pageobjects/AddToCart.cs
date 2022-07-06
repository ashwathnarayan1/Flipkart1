using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Pageobjects
{
    class AddToCart
    {
        private IWebDriver driver;
        public AddToCart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@class='_2KpZ6l _2U9uOA _3v1-ww']")]
        private IWebElement cart;

        public CartPage clickToAddToCart()
        {
            cart.Click();
            return new CartPage(driver);
        }
    }
}
