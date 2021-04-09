using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace SeleniumBasic
{
    public class DeleteTests
    {


        [Test]
        public void MaterialPageDelete()
        {

            // Launch the Crome Brower

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // Driver Maximized and applies Implicit Wait

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            // Identitfy and enter the username

            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            // Identitfy and enter the Password

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // Identitfy and Click the Login Button

            IWebElement Login_button = driver.FindElement(By.XPath("//input[@class='btn btn-default']"));
            Login_button.Click();


            // Click Adminstration drop down and select Time and Material module

            IWebElement Administration_page = driver.FindElement(By.XPath("//a[normalize-space()='Administration']"));
            Administration_page.Click();

            // Click Time and Meterial Module

            IWebElement TimeAndMaterial = driver.FindElement(By.LinkText("Time & Materials"));
            TimeAndMaterial.Click();

            Thread.Sleep(1000);

            IWebElement Click_Last_Btn = driver.FindElement(By.XPath("//a[@title='Go to the last page']"));
            Click_Last_Btn.Click();

            Thread.Sleep(1000);

            // Delete the Last result

            IWebElement Delete_Last_record =  driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]/td[last()]/a[2]"));
            Delete_Last_record.Click();

            Thread.Sleep(3000);

            //Accept the Alert message 
            var alert_win = driver.SwitchTo().Alert();

            alert_win.Accept();

            Thread.Sleep(2000);



            // Validation

            // IWebElement delete =  driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            IWebElement delete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr"));


            if(delete.Text == "Delete")
            {

                Console.WriteLine("Test Fail ");
            }
            else
            {
                Console.WriteLine("Test Pass");
            }

             // Delete operation

            // Login
            // adminstration
            // Time and Material
            //last Btn
            //clcik delete
            // perform Alert 

            // Thread.Sleep(2000);

            // // Save the updated record

            //IWebElement Updated_save_btn =  driver.FindElement(By.XPath("//input[@id='SaveButton']"));
            // Updated_save_btn.Click();

        }


    }
}