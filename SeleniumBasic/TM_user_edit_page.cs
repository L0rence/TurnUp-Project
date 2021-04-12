using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumBasic
{
    public class EditTests
    {
        

        [Test]
        public void MaterialPageEdited()
        {

            // Launch the Chrome Brower

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

            // Create New Record

            IWebElement Creat_New_Btn = driver.FindElement(By.XPath("//*[@id='container']/p/a"));

            Creat_New_Btn.Click();
            Thread.Sleep(3000);

            // Select TypeCode

             IWebElement Click_Typecode=  driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
            Click_Typecode.Click();
            
            // Select Time code // 
            IWebElement Click_Time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            Click_Time.Click();


            // Input filed Enter the Code//
           IWebElement Enter_code = driver.FindElement(By.XPath("//input[@id='Code']"));
            Enter_code.SendKeys("Lawrence");

            //Input filed Enter the Description 

            IWebElement Enter_Decription = driver.FindElement(By.XPath("//input[@id='Description']"));

            Enter_Decription.SendKeys("Upadted Description");

            // Input field Enter the Price per unit

            IWebElement Prive_per_unit = driver.FindElement(By.XPath("//input[@class='k-formatted-value k-input']"));
            Prive_per_unit.SendKeys("2123");

            //Click the SaveBtn
            IWebElement Save_btn = driver.FindElement(By.XPath("//input[@id='SaveButton']"));
            Save_btn.Click();
            Thread.Sleep(2000);
            // Click the Last Btn  

            IWebElement Click_Last_Btn = driver.FindElement(By.XPath("//a[@title='Go to the last page']"));
            Click_Last_Btn.Click();
            Thread.Sleep(3000);

            // Validate the data from the list

            /* IWebElement Last_Result=   driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
               if(Last_Result.Text == "Lawrence")
               {
                   Console.WriteLine("Text Matched ! Test Passed ");
               }
               else
               {
                   Console.WriteLine("Test Failed !");
               }
               Thread.Sleep(3000);*/
            // Click the edit Btn 

            IWebElement edit_Result =  driver.FindElement(By.XPath("//td[normalize-space()='Lawrence']//following::td//a[1]"));
            edit_Result.Click();

            // Edit the last result
           IWebElement edit_Descrpition =  driver.FindElement(By.XPath("//input[@id='Description']"));
            edit_Descrpition.Clear();
            edit_Descrpition.SendKeys("Edited Edited Description_9/4/21");

            Thread.Sleep(2000);

            // Save the updated record

           IWebElement Updated_save_btn =  driver.FindElement(By.XPath("//input[@id='SaveButton']"));
            Updated_save_btn.Click();
            Thread.Sleep(2000);

            // Go to Last Page and Validate the Delete record 

           IWebElement LastPge = driver.FindElement(By.XPath("//span[contains(text(),'Go to the last page')]"));

            LastPge.Click();

            // Validate the record

            Thread.Sleep(2000);

           string edit_record_name =  driver.FindElement(By.XPath("//td[normalize-space()='Lawrence']//following::td[2]")).Text;

            if(edit_record_name == "Edited Edited Description_9/4/21")
            {
                Console.WriteLine("Test Passed for the Edited record !!");
            }
            else
            {

                Console.WriteLine("Test Failed for the Edited record !!");
            }
        }


    }
}