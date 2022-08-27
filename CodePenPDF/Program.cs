
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace Selenium_Automation
{
    class Program
    {
        private const string ChromeDriverDirectory = "C:\\Users\\Dan\\bin\\ChromeDriver";

        static void Main(string[] args)
        {
            //Url = "https://codepen.io/danedens/full/ZExrjqV";
            // This will open up the URL
            using SuiteTests driver = new();
            driver.Dlcodepen();
            System.Threading.Thread.Sleep(30000);
        }
    }
}