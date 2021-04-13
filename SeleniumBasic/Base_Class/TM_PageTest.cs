using System;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumBasic.Pages;
using SeleniumBasic.Utilities;

namespace SeleniumBasic.Base_Class
{
    [TestFixture]
    public class Base_Class_Test:CommonDriver
    {

       //public IWebDriver driver;

 
        [SetUp]
        public void Login_TM()
        {

             driver = new ChromeDriver();
            // Login Page Objects
            LoginPage loginObj = new LoginPage();
            loginObj.LoginPage_Steps(driver);

        } 

        [Test]
        public void create_TM_Test()
        {
             
            // Home Page Objects 
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // TM Page Objects

            TM_Page tmPageObj = new TM_Page();
            tmPageObj.Create_NEW_TM_Record(driver);


        }

        [Test]
        public void edit_TM_Test()
        {
            // Login Page Objects 
            //LoginPage loginObj = new LoginPage();
            // loginObj.LoginPage_Steps(driver);

            // Home Page Objects 
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // TM Page Objects

            TM_Page tmPageObj = new TM_Page();
            tmPageObj.Edit_Created_Record(driver);
        }

        [Test]
        public void delete_TM_Test()
        {
            //// Login Page Objects 
            //LoginPage loginObj = new LoginPage();
            //loginObj.LoginPage_Steps(driver);

            // Home Page Objects 
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // TM Page Objects

            TM_Page tmPageObj = new TM_Page();
            tmPageObj.delete_Created_Record(driver);

        }

        [TearDown]

        public void Close_Browser()
        {
            driver.Close();

        }
    }
}
