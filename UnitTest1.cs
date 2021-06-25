using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using SProject1.PageObjects;

namespace Selenium_Demo
{
    public class Selenium_Demo
    {
        String test_url = "https://www.google.com";
       
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            // Local Selenium WebDriver

            driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome\\Application");

            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test_search()
        {
            driver.Url = test_url;

            System.Threading.Thread.Sleep(2000);

            IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));

            searchText.SendKeys("http://formy-project.herokuapp.com");

            IWebElement searchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@name='btnK']"));

            searchButton.Click();

            System.Threading.Thread.Sleep(5000);


            IWebElement clickonfirsturl = driver.FindElement(By.XPath("//div[@class='yuRUbf']//h3[@class='LC20lb DKV0Md']"));
            clickonfirsturl.Click();
            System.Threading.Thread.Sleep(3000);

            //-------------Select Hidden value from drop down text-------------------------
            //Click on the Autocomplte functionality - Link1
            //IWebElement autocomplte = driver.FindElement(By.LinkText("Autocomplete"));
            //autocomplte.Click();
            //System.Threading.Thread.Sleep(1000);
            //IWebElement autocomplteAddress = driver.FindElement(By.XPath("//div[@class='col-sm-8 col-sm-offset-2']//input[@id='autocomplete']"));
            //autocomplteAddress.Click();
            //System.Threading.Thread.Sleep(1000);
            //autocomplteAddress.SendKeys("1000 10th Avenue, New York, NY");
            ////mouse click - hidden values
            //System.Threading.Thread.Sleep(6000);
            //IWebElement resultSelect = driver.FindElement(By.ClassName("pac-item"));
            //resultSelect.Click();
            //------------------------------------------------------------

            //--------------Link2 - Scrolling functionality---------------------------------
            //IWebElement pagescroll = driver.FindElement(By.LinkText("Page Scroll"));
            //pagescroll.Click();
            //System.Threading.Thread.Sleep(4000);
            //IWebElement name1 = driver.FindElement(By.Id("name"));
            //Actions action = new Actions(driver);
            //action.MoveToElement(name1);
            //name1.SendKeys("Naincy Jain");
            //IWebElement date1 = driver.FindElement(By.Id("date"));
            //date1.SendKeys("01/01/2019");


            //--------------Link3 - SwitchTo Window/Alert---------------------------------

            //IWebElement clickonSwitchWindow = driver.FindElement(By.LinkText("Switch Window"));
            //clickonSwitchWindow.Click();
            //System.Threading.Thread.Sleep(4000);


            //------------------Window switch----------------------------
            //IWebElement openNewWindow = driver.FindElement(By.Id("new-tab-button"));
            //openNewWindow.Click();

            //String currentWindow = driver.CurrentWindowHandle;
            //foreach (string handle1 in driver.WindowHandles)
            //{
            //    driver.SwitchTo().Window(handle1);
            //}
            //System.Threading.Thread.Sleep(5000);
            //driver.SwitchTo().Window(currentWindow);
            //System.Threading.Thread.Sleep(5000);
            //// Click on alert - alert-button
            //IWebElement clickonAlertButton = driver.FindElement(By.Id("alert-button"));
            //clickonAlertButton.Click();
            //System.Threading.Thread.Sleep(1000);

            //var alert = driver.SwitchTo().Alert();
            //alert.Accept();


            //Complete webform fill up
            IWebElement formLink = driver.FindElement(By.LinkText("Complete Web Form"));
            //IWebElement formLink = driver.FindElement(By.CssSelector(".btn.btn-lg"));
            formLink.Click();
            System.Threading.Thread.Sleep(3000);

            FormDetails formdetail = new FormDetails();
            formdetail.submitForm(driver);

            //Call a submit form method
            WaitForAlertBanner waitForBanner = new WaitForAlertBanner();
            waitForBanner.waitForAlertBanner(driver);   //call wait for Alert banner
            //String  alert = getMessageFromAlertBanner(driver);//refactor
            Assert.AreEqual("The form was successfully submitted!", waitForBanner.getMessageFromAlertBanner(driver));
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Test Passed");
        }

      

        
       

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}