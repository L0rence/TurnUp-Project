using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
 
namespace SeleniumBasic.Pages
{
     
    public class LoginPage 
    {
        
        public void LoginPage_Steps(IWebDriver driver)
        {
              driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //maximise window
            driver.Manage().Window.Maximize();

            //identify and enter username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            //identify and enter password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            //identify and click login button
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            LoginButton.Click();
            Thread.Sleep(100);

            //validate if the user is able to login successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            //if (helloHari.Text == "Hello hari!")
            //{
            //    Console.WriteLine("Logged in successfully, test passed");

            //}
            //else
            //{
            //    Console.WriteLine("Login failed, test failed");
            //}
            //Thread.Sleep(200);


        }
    }

     
}
