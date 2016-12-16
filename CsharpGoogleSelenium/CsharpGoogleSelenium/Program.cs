using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpGoogleSelenium
{

    // Todo 1. Hämta plugin
    // Todo 2. Hitta sökfältet i google
    // Todo 3. Sök efter "Testautomatisering Stockholm"
    // Todo 4. Hitta sök knappen, klicka på den.
    class Program
    {
        // skapa en variabel som håller webdriver
        static IWebDriver driver;
        
       
            

        static void Main(string[] args)
        {
            //Ställa in driver till att använda Firefox
            driver = new FirefoxDriver();
            // Öppna google            
            driver.Url = "http://www.google.com";
            // Vänta på att sidan skall laddas.            
            Thread.Sleep(4000);
            // Hitta sök fältet och skriv in "Test Automatisering Stockholm"
            driver.FindElement(By.Id("lst-ib")).SendKeys("Testautomatisering Stockholm");
            // Hitta sök knappen, klicka på den.
            driver.FindElement(By.Id("_fZl")).Click();
            // Vänta tills dess att elementet är synligt
            Thread.Sleep(4000);
            IWebElement resultat = driver.FindElement(By.Id("resultStats"));
            // Ta fram resultatstats och skriv ut
            Console.WriteLine(resultat.Text);
            driver.Url = "http://www.test4quality.se";
            Thread.Sleep(2000);
            driver.FindElement(By.Id("menu-item-1286")).Click();

        }
    }
}
