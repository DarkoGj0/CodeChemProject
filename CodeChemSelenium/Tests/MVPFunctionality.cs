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
    public class MVPFunctionality
    {
        [Test]
        public void FunctionalityofMVPpage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://codechem.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("MVP")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//img[@alt='MVP Idea Validation Diary - A free Notion template that helps you validate your MVP idea | Product Hunt']")).Click();
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
            js.ExecuteScript("window.scrollTo(0,1400)");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,2200)");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,3000)");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,3800)");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,4600)");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,5400)");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,6200)");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,7000)");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,8600)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//img[contains(@src,'https://cdn.hashnode.com/res/hashnode/image/upload/v1628170054247/cl94fbxOW.png?w=400&h=210&fit=crop&crop=entropy&auto=compress,format&format=webp&fm=blurhash')]")).Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Window(tabs[0]);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//img[contains(@src,'https://cdn.hashnode.com/res/hashnode/image/upload/v1627293435786/KM8jzaHGt.png?w=400&h=210&fit=crop&crop=entropy&auto=compress,format&format=webp&fm=blurhash')]")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(tabs[0]);
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,9500)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//img[contains(@src,'https://cdn.hashnode.com/res/hashnode/image/upload/v1628173772868/nkLtXVMpm.png?w=400&h=210&fit=crop&crop=entropy&auto=compress,format&format=webp&fm=blurhash')]")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(tabs[0]);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//img[contains(@src,'https://cdn.hashnode.com/res/hashnode/image/upload/v1628766734965/ZlBu1w3LV.png?w=400&h=210&fit=crop&crop=entropy&auto=compress,format&format=webp&fm=blurhash')]")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(tabs[0]);
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
