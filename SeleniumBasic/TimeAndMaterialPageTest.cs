using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace SeleniumBasic
{
    public class Tests
    {
        

        [Test]
        public void MaterialPageTest()
        {
            //Launch the Firefox browser

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            // Enter Login Value

            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            // Enter The password

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // Click Login Button

           IWebElement LoginButton = driver.FindElement(By.XPath("//input[@class='btn btn-default']"));
           LoginButton.Click();

            // Identify tests to automate on Time and Material module

            // Navigate to Adminstration Page

            IWebElement Administration_page = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a "));
            Administration_page.Click();

            // Naviagte to TimeMaterial Page

           IWebElement TimeMaterialPage =  driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));

           TimeMaterialPage.Click();

            //Click Create New Button

            IWebElement Create_New_Btn = driver.FindElement(By.XPath("//a[@class='btn btn-primary']"));

            Create_New_Btn.Click();

            //Select Type code from the dropdown menu 
            IWebElement select_Arrow_Btn = driver.FindElement(By.XPath("//span[contains(text(),'select')]"));
            select_Arrow_Btn.Click();
             

           // Select the type code "Time"
            IWebElement Input_code = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            Input_code.Click();


            //Click On the code input field and enter the value "LAWRENCE_7/4/2021"

            IWebElement Select_time = driver.FindElement(By.Id("Code"));

            Select_time.SendKeys("LAWRENCE_8/4/2021");

            // Click on the Description Input field and Enter the Field 

             IWebElement description =  driver.FindElement(By.Id("Description"));

            description.SendKeys("Lawrence_description_Created_on_8/4/2021");

            // Click on the Price Unit and enter the value

            //IWebElement Price_unit =  driver.FindElement(By.Id("Price"));  // ID not working so i am using xpath 

            // IWebElement Price_unit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));

           // driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[4]/div/span[1]/span/input[1]")).SendKeys("sdd");

           
           // Price_unit.SendKeys("10");

            //Click on the Save Button

           IWebElement Save_btn =  driver.FindElement(By.Id("SaveButton"));
             Save_btn.Click();

            // Search the username is saved on the list or not

             Thread.Sleep(3000);

            String name = "LAWRENCE_7/4/2021";

            String row_name = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]")).Text;

            while (true)
            {
                if (row_name.Equals(name))
                {
                    break;
                }
                else
                {
                    driver.FindElement(By.XPath("//span[@class='k-icon k-i-arrow-e']")).Click();

                }
            }

            Thread.Sleep(3000);


           IWebElement delete =  driver.FindElement(By.ClassName("k-button k-button-icontext k-grid-Delete"));

           delete.Click();











        }


    }
}