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

namespace CodeChemSelenium.Tests
{
    public class ButtonContact
    {
        [Test]
        public void FunctionalityofButtonContact()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://codechem.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Contact", driver.FindElement(By.XPath("//div[@id='__next']/div/div/div/div/div/a[8]/button")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/div/div/div/div/a[8]/button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("Name")).Click();
            driver.FindElement(By.Name("Name")).Clear();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("Name")).SendKeys("Darko Gjorgjievski");
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Darko Gjorgjievski", driver.FindElement(By.Name("Name")).GetAttribute("value"));
            Thread.Sleep(2000);
            driver.FindElement(By.Name("Email")).Clear();
            driver.FindElement(By.Name("Email")).SendKeys("d.gjorgjievski96@gmail.com");
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("d.gjorgjievski96@gmail.com", driver.FindElement(By.Name("Email")).GetAttribute("value"));
            Thread.Sleep(2000);
            driver.FindElement(By.Name("PhoneNumber")).Clear();
            driver.FindElement(By.Name("PhoneNumber")).SendKeys("078847199");
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("078847199", driver.FindElement(By.Name("PhoneNumber")).GetAttribute("value"));
            Thread.Sleep(2000);
            driver.FindElement(By.Name("CompanyName")).Clear();
            driver.FindElement(By.Name("CompanyName")).SendKeys("CodeChem");
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("CodeChem", driver.FindElement(By.Name("CompanyName")).GetAttribute("value"));
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//img[@alt='Checkbox unchecked']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("Message")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("Message")).SendKeys("Imagine an application designed specifically for software testers. This app would include a bug tracker to log and prioritize issues, a test case manager to organize and execute test cases, and real-time collaboration tools to streamline communication with developers. It’s a one-stop solution to make testing more efficient and ensure software quality");
            Thread.Sleep(2000);
            driver.Close();
        }
    }
}
