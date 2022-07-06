using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using Task1.Pageobjects;
using Task1.Utilities;
using WebDriverManager.DriverConfigs.Impl;

namespace Task1
{
    public class TestCase : Base
    {
       

        [Test]
        public void Login ()
        {

            
            LoginPage loginpage = new LoginPage(getDriver());
            SearchPage searchpage = loginpage.validLogin("9738020725", "ashwathnarayan");


            searchpage.explicitWait();
            ClickOnItem clickonitem = searchpage.validSearch("samsung galaxy m32");
            searchpage.getEnter().SendKeys(Keys.Enter);

            
            clickonitem.explicitWait();
            clickonitem.getClick().Click();


            driver.SwitchTo().Window(driver.WindowHandles[1]);
            AddToCart addtocart = new AddToCart(getDriver());
            CartPage cartpage = addtocart.clickToAddToCart();


            cartpage.explicitWait();
            cartpage.getRemove().Click();

        }
    }
}