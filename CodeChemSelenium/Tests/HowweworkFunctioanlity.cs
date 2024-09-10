using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace CodeChemSelenium.Tests
{
    public class HowweworkFunctionality
    {
        [Test]
        public void FunctionalityofHowweWork()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://codechem.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("How we work")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("How we work — CodeChem", driver.Title);
            Thread.Sleep(1000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,700)");
            ClassicAssert.AreEqual("How we work", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div/div/div/div/h3")).Text);
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollTo(0,1000)");
            Thread.Sleep(1000);
            ClassicAssert.AreEqual("Agile Software Development", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div/h3")).Text);
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollTo(0,1300)");
            Thread.Sleep(1000);
            ClassicAssert.AreEqual("All the team is aligned", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div[2]/h3")).Text);
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollTo(0,1600)");
            Thread.Sleep(1000);
            ClassicAssert.AreEqual("Teamwork", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div[3]/h3/span")).Text);
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollTo(0,1800)");
            Thread.Sleep(1000);
            ClassicAssert.AreEqual("Team Motivation", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[2]/div[4]/h3")).Text);
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,2200)");
            Thread.Sleep(1000);
            ClassicAssert.AreEqual("Support & Maintenance", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[3]/div[3]/div/h3")).Text);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[3]/div/div[2]/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[3]/div/div[2]/span")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,2400)");
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Custom Software", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[3]/div[2]/div/h3")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[3]/div[2]/div[2]/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[3]/div[2]/div[2]/span")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,2800)");
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Research & Ideation", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[3]/div/div/h3")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[3]/div[3]/div[2]/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[3]/div[3]/div[2]/span")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,3100)");
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Team Augmentation", driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[3]/div[4]/div/h3")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[3]/div[4]/div[2]/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div[2]/div[3]/div[4]/div[2]/span")).Click();
            Thread.Sleep(2000);
            driver.Close();
        }
    }
}
