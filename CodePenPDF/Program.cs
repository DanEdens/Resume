
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Xml.Linq;

namespace Selenium_Automation
{
    class Program
    {
        private const string ChromeDriverDirectory = "C:\\Users\\Dan\\bin\\ChromeDriver";
        private static object? jobGeo;

        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(ChromeDriverDirectory);

            // This will open up the URL
            driver.Url = "https://codepen.io/danedens/full/ZExrjqV";
            System.Threading.Thread.Sleep(10000);
            IWebElement element = driver.FindElement(By.Id("body > div:nth-child(3) > div > div.section.middle.clearfix > div > h2 > i"));
            
            element.Click();
        }
    }
}