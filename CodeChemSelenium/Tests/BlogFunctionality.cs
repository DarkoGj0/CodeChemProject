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
            driver.Close();
            }
     }
}
