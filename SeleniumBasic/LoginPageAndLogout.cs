using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic
{
    public class LoginTestAndLogout
    {
        

        [Test]
        public void LoginPageTest()
        {

            // Launch the Brower

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            // Identitfy and enter the username

            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            // Identitfy and enter the Password

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // Identitfy and Click the Login Button

            IWebElement Login_button = driver.FindElement(By.XPath("//input[@class='btn btn-default']"));
            Login_button.Click();

            // Validate the "hello hari" is displayed  or not

            String Display_name = driver.FindElement(By.XPath("/html/body/div[3]/div/div/form/ul/li/a")).Text;
            if (Display_name == "Hello hari!")
            {
                Console.WriteLine("Hello hari! is matching with the display message | Test Passed !!");
            }
            else
            {
                Console.WriteLine("Test Failed !!");
            }



            // Validate using search keyword and find the name is saved on the list

            // Identify tests to automate on Time and Material module

            // Navigate to Adminstration Page

            IWebElement Administration_page = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a "));
            Administration_page.Click();

            // Naviagte to TimeMaterial Page

            IWebElement TimeMaterialPage = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));

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

            IWebElement description = driver.FindElement(By.Id("Description"));

            description.SendKeys("Lawrence_description_Created_on_8/4/2021");


            // Click on the Price Unit and enter the value

            driver.FindElement(By.XPath("//input[@class='k-formatted-value k-input']")).Click();

             IWebElement Price_unit = driver.FindElement(By.XPath("//input[@id='Price']"));

            
             Price_unit.SendKeys("232");

       



        // Price_unit.SendKeys("10");

        //Click on the Save Button

            IWebElement Save_btn = driver.FindElement(By.Id("SaveButton"));
            Save_btn.Click();



            // Validate and Clcick the Logout

            //IWebElement Logout_btn = driver.FindElement(By.XPath("//a[contains(text(),'Log off')]"));
            //IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            //executor.ExecuteScript("arguments[0].click();", Logout_btn);

            Thread.Sleep(3000);


            // Actual validation strats 

            driver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e']")).Click();



            IWebElement Actual_text =  driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if(Actual_text.Text == "LAWRENCE_8/4/2021")
            {
                Console.WriteLine("Test Passed !!");
            }
            else
            {
                Console.WriteLine("Test Failed !! ");
            }

            // Edit the value 

           IWebElement Edit_Btn =  driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));

            Edit_Btn.Click();

            IWebElement Edit_Description =  driver.FindElement(By.XPath("//input[@id='Description']"));
            Edit_Description.SendKeys("Edited Description ");

            Thread.Sleep(3000);
            // Save the Edited Details

            driver.FindElement(By.XPath("//input[@id='SaveButton']")).Click();

        }


    }
}