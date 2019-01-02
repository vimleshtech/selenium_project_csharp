using System;
using System.Collections.Generic;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumDay1
{
    class Practice_selenium_day1
    {

        public void open()
        {
            Console.WriteLine("web driver is started...");

            //IWebDriver : is interface
            //ChromeDriver : is inbuilt class

            //open web driver
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/"; //open url 

            driver.FindElement(By.Id("email")).SendKeys("test");

            driver.FindElement(By.Id("pass")).SendKeys("test");

            driver.FindElement(By.Id("u_0_2")).Click();

            Console.ReadKey();

        }
    }
}
