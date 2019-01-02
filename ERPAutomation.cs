using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace SeleniumDay1
{
    class ERPAutomation
    {

        IWebDriver driver = null;
        [SetUp]
        public void Initazlize()
        {
            driver = new ChromeDriver();
            driver.Url = "http://erp.techvisionit.com/";
        }
        [Test]
        public void TestFunction()
        {
           // string src = driver.PageSource;
            //Console.WriteLine(src);

           // string title = driver.Title;
           // Console.WriteLine(title);

          //  string url = driver.Url;
           // Console.WriteLine(url);

            
            driver.FindElement(By.Id("txtUserName")).SendKeys("chahat");

            driver.FindElement(By.Id("txtPassword")).SendKeys("chahat@765");

            driver.FindElement(By.Id("btnSubmit")).Click();


            //driver.Navigate().Refresh();
            //driver.Navigate().Back();

            

        }

        [Test]
        public void TestGo()
        {
            driver.FindElement(By.XPath("//*[@id='aspnetForm']/div[3]/div/ul[2]/li[3]/img")).Click();
            driver.FindElement(By.PartialLinkText("Enquiry")).Click();


        }

        [TearDown]
        public void closeDriver()
        {
            //driver.Close();
        }

    }
}
