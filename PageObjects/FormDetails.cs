using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SProject1.PageObjects
{
    public class FormDetails
    {
        public void submitForm(IWebDriver driver)
        {
            IWebElement firstName = driver.FindElement(By.Id("first-name"));
            firstName.SendKeys("Naincy");
            System.Threading.Thread.Sleep(1000);

            IWebElement lastName = driver.FindElement(By.Id("last-name"));
            lastName.SendKeys("Jain");
            System.Threading.Thread.Sleep(1000);

            IWebElement jobtitle = driver.FindElement(By.Id("job-title"));
            jobtitle.SendKeys("Software Engineer");
            System.Threading.Thread.Sleep(1000);

            IWebElement radiobutton = driver.FindElement(By.Id("radio-button-2"));
            radiobutton.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement checkbox = driver.FindElement(By.Id("checkbox-2"));
            checkbox.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement dropDownBox = driver.FindElement(By.Id("select-menu"));
            System.Threading.Thread.Sleep(1000);
            //  SelectElement se = new SelectElement(dropDownBox);
            dropDownBox.Click();
            IWebElement dropDownValue = driver.FindElement(By.XPath("//div[@class='col-sm-4 col-sm-offset-2']//select[@class='form-control']//option[@value='3']"));
            dropDownValue.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement datefield = driver.FindElement(By.Id("datepicker"));
            datefield.SendKeys("10/10/2020");
            datefield.SendKeys(Keys.Return);//Close the date picker
            System.Threading.Thread.Sleep(2000);

            // IWebElement buttonSubmit = driver.FindElement(By.XPath("div[@class='col-sm-4 col-sm-offset-2']//a[@class='btn btn-lg btn-primary']"));
            IWebElement buttonSubmit = driver.FindElement(By.CssSelector(".btn.btn-lg.btn-primary"));
            buttonSubmit.Click();
        }

    }
}
