using NUnit.Framework.Legacy;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeChemSelenium.Tests
{
    public class AboutFunctionality
    {
        [Test]
        public void FunctionalityofAbout()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://codechem.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("About")).Click();
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,700)");
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("How we work", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div/div[3]/a/button")).Text);
            Thread.Sleep(500);
            ClassicAssert.AreEqual("SINCE", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div/span")).Text);
            Thread.Sleep(500);
            ClassicAssert.AreEqual("PROFESIONALS IN-HOUSE", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div[2]/span")).Text);
            Thread.Sleep(500);
            ClassicAssert.AreEqual("PROJECTS DELIVERED", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div[3]/span")).Text);
            Thread.Sleep(500);
            ClassicAssert.AreEqual("CLIENTS SERVED", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div[4]/span")).Text);
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,1100)");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,1800)");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,2200)");
            Thread.Sleep(2000);
            driver.Close();
        }
    }
}
