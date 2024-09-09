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

namespace CodeChemSelenium.Tests
{
    public class CassesFunctionality
    {
        [Test]
        public void CassesFunctinality()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://codechem.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Cases")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Our Work — CodeChem", driver.Title);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div/div[2]/div/div/a/div/div/div[2]")).Click();
            ClassicAssert.AreEqual("Mediawire Mobile — CodeChem", driver.Title);
            ClassicAssert.AreEqual("Mediawire Mobile", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div/div/div/a/div/span")).Click();
            Thread.Sleep(2000);
            var tabs = driver.WindowHandles;
            if (tabs.Count > 1)
            {
                driver.SwitchTo().Window(tabs[1]);
                Thread.Sleep(2000);
                driver.Close();
                driver.SwitchTo().Window(tabs[0]);
            }
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,600)");
            ClassicAssert.AreEqual("The Idea", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div[2]/div[2]/div/h1")).Text);
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,1800)");
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("The Technical Challenge", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div[2]/div[3]/div/h1")).Text);
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,3200)");
            ClassicAssert.AreEqual("The Solution", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div[2]/div[4]/div/h1")).Text);
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,5800)");
            ClassicAssert.AreEqual("Technologies", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div[2]/div[5]/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//img[contains(@src,'https://api.codechem.com/uploads/vidsbeats_copy_36fd440262.jpg')]")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("VidsBeats — CodeChem", driver.Title);
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,1400)");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div[2]/div[2]/div[2]/video")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div[2]/div[2]/div[2]/video")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//img[contains(@src,'https://api.codechem.com/uploads/lana_57cae1ec0a.jpg')]")).Click();
            ClassicAssert.AreEqual("Lana — CodeChem", driver.Title);
            driver.Close();
        }
    }
}
