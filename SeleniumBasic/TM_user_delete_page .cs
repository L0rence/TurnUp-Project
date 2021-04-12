using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumBasic
{
    public class DeleteTests
    {


        [Test]
        public void MaterialPageDelete()
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

            Thread.Sleep(1000);
            

            IWebElement Click_Last_Btn = driver.FindElement(By.XPath("//a[@title='Go to the last page']"));
            Click_Last_Btn.Click();

            Thread.Sleep(1000);



            

            // Delete the record name "delete "from the list

            IWebElement delete_record=  driver.FindElement(By.XPath("//td[normalize-space()='delete']//following::td[4]//a[2]"));
            String deletename = delete_record.Text;
            
            delete_record.Click();

            //Accept the Alert Button

            driver.SwitchTo().Alert().Accept();

            

             //Thread.Sleep(3000);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);


            // After delete the record check again -> go to last page and verify the "delete" record

            //IWebElement Click_Last_Btn1 = driver.FindElement(By.XPath("//a[@title='Go to the last page']"));
            //  Click_Last_Btn1.Click();



            //Verify the delete record is present or not

            string delete_name = driver.FindElement(By.XPath("//td[normalize-space()='delete']")).Text;

            //String deleteRecord = "delete";

            if (delete_name != "delete")
            {
                Console.WriteLine( "Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

            // Testing mkmm

            //String name_01 = "delete";

            //while (true)
            //{
            //    string text = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]")).Text;
            //    if (text.Equals(name_01))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[5]/td[1]"));
            //    }
            //}

            // Delete the Last result

            //IWebElement Delete_Last_record =  driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]/td[last()]/a[2]"));
            //Delete_Last_record.Click();

            //String before_xpath   = ("//*[@id='tmsGrid']/div[3]/table/tbody/tr[");
            // String after_xpath = "]/td[1]";

            // for (int i = 1; i < 5; i++)
            //  {
            //     String name = driver.FindElement(By.XPath(before_xpath + i + after_xpath)).Text;

            //      Console.WriteLine(name);
            // }

            // Thread.Sleep(3000);

            //Accept the Alert message 
            //var alert_win = driver.SwitchTo().Alert();

            //alert_win.Accept();

            //Thread.Sleep(3000);



            // Validation

            // IWebElement delete =  driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            //IList delete = driver.FindElements(By.XPath("//*[@id='tmsGrid']/div[3]/table"));
            //Console.WriteLine(delete.Count);

            //foreach (var item in delete)
            //{
            //    Console.WriteLine(item);
            //}

            //String before_xpath = "//*[@id='tmsGrid']/div[3]/table/tbody/tr[";
            //String after_xpath = "]/td[1]";

            //for (int i = 1; i < 6; i++)
            //{
            //   String name = driver.FindElement(By.XPath(before_xpath + i + after_xpath)).Text;
            //    Console.WriteLine(name);
            //}
            //*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]
            //*[@id="tmsGrid"]/div[3]/table/tbody/tr[3]/td[1]
            ////tbody/tr[1]/td[1]
            /////tbody/tr[2]/td[1]
            /////tbody/tr[3]/td[1]

            //IList para = driver.FindElements(By.XPath("//ul[@class='dropdown-menu']//li//a"));

            // Console.WriteLine(para.Count);

            // foreach (var item in para)
            // {
            //     Console.WriteLine(item);
            // }


            //if (delete.Text == "Delete")
            //{

            //    Console.WriteLine("Test Fail ");
            //}
            //else
            //{
            //    Console.WriteLine("Test Pass");
            //}

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