using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasic.Pages
   
{
    public class HomePage
    {
        public void NavigateToTM(IWebDriver driver)
        {

            // Navigate to Adminstration Page

            IWebElement Administration_page = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a "));
            Administration_page.Click();

            // Naviagte to TimeMaterial Page

            IWebElement TimeMaterialPage = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));

            TimeMaterialPage.Click();
            Thread.Sleep(2000);
        }
    }
}
