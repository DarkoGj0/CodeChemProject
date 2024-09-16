using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Timers;

namespace CodeChemSelenium.Tests
{
    public class ServicesFunctionality
    {
        [Test]
        public void FunctionalityofSerrvices()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://codechem.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Services")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Services — CodeChem", driver.Title);
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,700)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div/div/div/a/div/div[2]/h6")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,900)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div/div/div[2]/a/div/div[2]")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Consulting", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,1200)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div/div/div[2]/a[2]/div/div/p")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Project Management", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,1700)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div/div/div[2]/a[3]/div/div/h4")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Outsourcing Solutions", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,2000)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div/div/div[3]/a/div/div/p")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Software Development", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000); 
            js.ExecuteScript("window.scrollTo(0,2100)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div/div/div[3]/a[2]/div/div")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Cloud & DevOps", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,2400)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div/div/div[3]/a[3]/div/div/h4")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("UI/UX Design", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,2700)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div/div/div[3]/a[4]/div/div/h4")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Support & Maintenance", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,2900)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div/div/div[3]/a[5]/div/div")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Machine Learning", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Close();
        }
    }
}
