using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

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
            driver.FindElement(By.LinkText("Cases")).Click();
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://codechem.com/services");
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Services")).Click();
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://codechem.com/how-we-work");
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("How we work")).Click();
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://codechem.com/company");
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("About")).Click();
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://codechem.com/careers");
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Careers")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Blog")).Click();
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://blog.codechem.com/");
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
