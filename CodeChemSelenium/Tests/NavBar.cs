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
using System.Timers;
using System.Runtime.InteropServices;

namespace CodeChemSelenium.Tests
{
    public class NavBar
    {
        [Test]
        public void FunctionalityofNavBar()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://codechem.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("MVP")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("MVP", driver.FindElement(By.LinkText("MVP")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Cases")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Cases", driver.FindElement(By.LinkText("Cases")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Services")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Services", driver.FindElement(By.LinkText("Services")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("How we work")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("How we work", driver.FindElement(By.LinkText("How we work")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("About")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("About", driver.FindElement(By.LinkText("About")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Careers")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Careers", driver.FindElement(By.LinkText("Careers")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Blog")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Blog", driver.FindElement(By.LinkText("Blog")).Text);
            Thread.Sleep(2000);
            var tabs = driver.WindowHandles;
            if (tabs.Count > 1)
            {
                driver.SwitchTo().Window(tabs[1]);
                Thread.Sleep(2000);
                driver.Close();
                driver.SwitchTo().Window(tabs[0]);
            }
            Thread.Sleep(2000);
            driver.Close();
            
        } 
    }
}
