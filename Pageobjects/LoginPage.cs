using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Pageobjects
{
    class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }



        [FindsBy(How = How.XPath, Using = "//input[@class='_2IX_2- VJZDxU']")]
        private IWebElement phNo ;

        [FindsBy(How = How.XPath, Using = "//input[@type='password']")]
        private IWebElement password ;

        [FindsBy(How = How.XPath, Using = "//button[@class='_2KpZ6l _2HKlqd _3AWRsL']")]
        private IWebElement signIn ;

        public SearchPage validLogin (string pnum, string pass)
        {
            phNo.SendKeys(pnum);
            password.SendKeys(pass);
            signIn.Click();
            return new SearchPage(driver);


        }


    }

}
