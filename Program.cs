using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////create reference for the browser
            //IWebDriver driver = new ChromeDriver();

            ////navigate to the browser
            //driver.Navigate().GoToUrl("https://www.google.com/");
            //Thread.Sleep(2000);

            ////identify the google search textbox
            //IWebElement ele = driver.FindElement(By.Name("q"));

            ////enter the value in google search textbox
            //ele.SendKeys("javatpoint tutorials");
            //Thread.Sleep(2000);

            //// click on the Google search button  
            //ele.SendKeys(Keys.Enter);

            ////close the browser  
            //driver.Close();
            //Console.Write("test case ended");

            IWebDriver test = new ChromeDriver();
            test.Navigate().GoToUrl("https://www.saucedemo.com/");
            IWebElement euser = test.FindElement(By.Name("user-name"));
            euser.SendKeys("standard_user");
            IWebElement epwd = test.FindElement(By.Name("password"));
            epwd.SendKeys("secret_sauce");
            IWebElement elog = test.FindElement(By.Name("login-button"));
            elog.Click();

            IList<IWebElement> names = test.FindElements(By.ClassName("inventory_item_name"));
            IList<IWebElement> listOfnames = new List<IWebElement>();

            for (int i = 0; i < names.Count; i++)
            {
                names = test.FindElements(By.ClassName("inventory_item_name"));

                if (!string.IsNullOrEmpty(names[i].Text))
                    names[i].Click();
                Thread.Sleep(2000);
                IWebElement eback = test.FindElement(By.Id("back-to-products"));
                eback.Click();
                Thread.Sleep(2000);
            }
            
            
            Thread.Sleep(2000);
            test.Close();
            Console.Write("Test closure");

        }
    }
}
