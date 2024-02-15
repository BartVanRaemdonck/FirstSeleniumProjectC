using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace FirstSeleniumC.Tests
{

    [TestFixture]
    public class Oefening1
	{
        [Test]
        public void Test()
		{
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://www.axxes.com");
            //navigate to https://google.com
            //navigate back
            //assert that the title of the page is the one from the Axxes website
            driver.Quit();


        }
	}
}

