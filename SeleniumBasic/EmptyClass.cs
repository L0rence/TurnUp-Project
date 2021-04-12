using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic
{
    public class EmptyClass
    {
        public EmptyClass()
        {
            IWebDriver driver  = new ChromeDriver();
            driver.Url = "https://www.google.com/ncr";
            driver.FindElement(By.Name("q")).SendKeys("cheese" + Keys.Enter);


           // WebDriverWait wait = new(driver, TimeSpan.FromSeconds(20));



            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            IWebElement firstResult = wait.Until(e => e.FindElement(By.XPath("//a/h3")));

            Console.WriteLine(firstResult.Text);
        }
    }
}
