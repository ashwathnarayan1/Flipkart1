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
    class ClickOnItem
    {
        private IWebDriver driver;
        public ClickOnItem(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//img[@alt='SAMSUNG Galaxy M32 5G (Sky Blue, 128 GB)']")]
        private IWebElement click;

        public IWebElement getClick()
        {
            return click;

        }

        public void explicitWait()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='_2I9KP_'][1]")));
        }





    }
}
