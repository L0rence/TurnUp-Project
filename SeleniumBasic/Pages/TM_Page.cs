using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasic.Pages
   
{
    public class TM_Page
    {
        public void Create_NEW_TM_Record(IWebDriver driver)
        {

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

            Select_time.SendKeys("LA");

            Thread.Sleep(2000);

            // Click on the Description Input field and Enter the Field 

            IWebElement description = driver.FindElement(By.Id("Description"));

            description.SendKeys("Lawrence_description_Created_on_12/4/2021");

            // Click on the Price Unit and enter the value

            IWebElement price_input_f1 = driver.FindElement(By.XPath("//input[@class='k-formatted-value k-input']"));
            price_input_f1.Click();

            IWebElement Price_input_f2 = driver.FindElement(By.XPath("//input[@id='Price']"));
            Price_input_f2.SendKeys("1232");


            //Click the SaveBtn
            IWebElement Save_btn = driver.FindElement(By.XPath("//input[@id='SaveButton']"));
            Save_btn.Click();
            Thread.Sleep(2000);
            // Click the Last Btn  

            IWebElement Click_Last_Btn = driver.FindElement(By.XPath("//a[@title='Go to the last page']"));
            Click_Last_Btn.Click();
            Thread.Sleep(3000);

            // Validation for create new record

            IWebElement Check_Record = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

           // Assert.That(Check_Record.Text, Is.EqualTo("LA"),"Test Failed !! ");

         if(Check_Record.Text == "LA")
            {
                Console.WriteLine("Created Successful");
                Assert.Pass("Record Created Sucessfull, Test Passed!");
            }
            else
            {
                Console.WriteLine("Created un successful");
                Assert.Fail("Record Created Unsucessful, Test Failed!");
            } 

            


        }

        public void Edit_Created_Record(IWebDriver driver)
        {
            
            IWebElement LastPge = driver.FindElement(By.XPath("//span[contains(text(),'Go to the last page')]"));

            LastPge.Click();
            Thread.Sleep(2000);

            IWebElement edit_Result = driver.FindElement(By.XPath("//td[normalize-space()='LA']//following::td//a[1]"));
            edit_Result.Click();

            // Edit the last result
            IWebElement edit_Descrpition = driver.FindElement(By.XPath("//input[@id='Description']"));
            edit_Descrpition.Clear();
            edit_Descrpition.SendKeys("Edited Edited Description");

            Thread.Sleep(2000);

            // Save the updated record

            IWebElement Updated_save_btn = driver.FindElement(By.XPath("//input[@id='SaveButton']"));
            Updated_save_btn.Click();
            Thread.Sleep(2000);

            // Go to Last Page and Validate the Delete record 

            IWebElement LastPge1 = driver.FindElement(By.XPath("//span[contains(text(),'Go to the last page')]"));

            LastPge1.Click();

            // Validate the record

            Thread.Sleep(2000);

            string edit_record_name = driver.FindElement(By.XPath("//td[normalize-space()='LA']//following::td[2]")).Text;

           

            if (edit_record_name == "Edited Edited Description")
            {
                Console.WriteLine("Test Passed for the Edited record !!");
                Assert.Pass("Edited Successful!, Test Passed");
            }
            else
            {

                Console.WriteLine("Test Failed for the Edited record !!");
                Assert.Fail("Edited Failed! , Test Failed ");
            }
        }


        /****************************/
        /*
        ////click Edit button
        driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();
        Thread.Sleep(2500);

        //edit code
        IWebElement element = driver.FindElement(By.Name("Code"));
        element.Clear();
        element.SendKeys("1234");
        /// driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("0002");
        Thread.Sleep(2500);

        //save record
        driver.FindElement(By.Id("SaveButton")).Click();
        Thread.Sleep(3500);

        //goto last page
        driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
        Thread.Sleep(3500);
        //validate if last row contains updated record 
        IWebElement updatedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));


        if (updatedCode.Text == "1234")
        {
            Console.WriteLine("Record updated, edit successful");
        }
        else
        {
            Console.WriteLine("Record not updated, edit not successful");
        }
        Thread.Sleep(3500);
}
        */

        /******************/


    

    public void delete_Created_Record(IWebDriver driver)
        {
            //delete record
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();
            Thread.Sleep(2500);
            //click ok in pop up
            driver.SwitchTo().Alert().Accept();

            //**verify if record deleted
            //check record count
            ////*[@id="tmsGrid"]/div[4]/span[2]
            //  Console.WriteLine("Record is deleted");

            // Validation for Delete Record
            Thread.Sleep(3000);
            IWebElement verify_delete_rocord = driver.FindElement(By.XPath("//span[contains(text(),'1 - 10 of 5447 items')]"));

            // ************ Reduced number from the xpath when you run the test **********// 

            if (verify_delete_rocord.Text == "1 - 10 of 5448 items")
            {
                Console.WriteLine("Number Not matching so Test Failed !");
                Assert.Pass("Number Not matching so Test Failed ! ");
                
            }
            else
            {
                Console.WriteLine("Number matching so Test Pass !");
                Assert.Fail("Number matching so Test Pass ! ");
               
            }


            //********** other way *********//

            //IWebElement RC = driver.FindElement(By.XPath("//td[contains(text(),'$10.00')]"));
            //if(RC.Text == "$10.00")
            //{
            //    Console.WriteLine("Test ");
            //    Assert.Pass("Test Pass");
            //}
            //else
            //{
            //    Assert.Fail("Test Fail");
            //}
        }


    }
}
