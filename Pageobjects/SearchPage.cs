using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Pageobjects
{
    class SearchPage
    {
       private IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@class='_3704LK']")]
        private IWebElement search;

        [FindsBy(How = How.XPath, Using = "//input[@class='_3704LK']")]
        private IWebElement enter;

        

        public ClickOnItem validSearch(string find)
        {
            search.SendKeys(find);
            return new ClickOnItem(driver);
        }

        public IWebElement getEnter()
            {
            return enter;
        }

        public void explicitWait()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@class='_3704LK']")));
        }

    }
}
