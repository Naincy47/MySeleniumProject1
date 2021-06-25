using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SProject1.PageObjects
{
    public class WaitForAlertBanner
    {
        public void waitForAlertBanner(IWebDriver driver)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector(".alert.alert-success")));
        }

        public string getMessageFromAlertBanner(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector(".alert.alert-success")).Text;
        }
    }
}
