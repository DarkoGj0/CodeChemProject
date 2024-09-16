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
    public class BlogFunctionality
    {
       
    
     [Test]
       public void FunctionalityofBlog()
        {
             IWebDriver driver = new ChromeDriver();
            driver.Url = "https://codechem.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Blog")).Click();
            Thread.Sleep(2000);
            var tabs = driver.WindowHandles;
            if (tabs.Count > 1)
            {
                driver.SwitchTo().Window(tabs[0]);
                Thread.Sleep(2000);
                driver.Close();
                driver.SwitchTo().Window(tabs[1]);
            }
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Follow'])[1]/preceding::*[name()='svg'][9]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Follow'])[1]/preceding::*[name()='svg'][9]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/header/div/div[3]/div[3]/div/nav/a[2]/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/header/div/div[3]/div[3]/div/nav/a[3]/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/header/div/div[3]/div[3]/div/nav/a[4]/span")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/header/div/div[3]/div[3]/div/nav/a[5]/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='__next']/div/header/div/div[3]/div[3]/div/nav/a[6]/span")).Click();
            Thread.Sleep(2000); 
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Follow'])[1]/preceding::*[name()='svg'][10]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='text']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("But it works on my machine?!");
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://blog.codechem.com/but-it-works-on-my-machine-onnx-101");
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//html")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://blog.codechem.com/");
            Thread.Sleep(2000);
            driver.Close();
        }
     }
}
