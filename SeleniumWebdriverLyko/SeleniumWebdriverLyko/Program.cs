﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriverLyko
{
    class Program
    {
        static IWebDriver driver;
        static void Main(string[] args)
        {
            driver = new FirefoxDriver();
                      
            driver.Url = "http://Lyko.se";

            Thread.Sleep(4000);
            
            driver.FindElement(By.Name("q")).SendKeys("Schampoo");
            Thread.Sleep(4000);
            driver.FindElement(By.ClassName("A69wSs")).Click();
            Thread.Sleep(4000);

            driver.FindElement(By.CssSelector("div._1Nvacq:nth-child(1) > button:nth-child(2) > span:nth-child(1)")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.CssSelector("._1w9fSZ")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.CssSelector("a._3itYIP:nth-child(1)")).Click();
            Thread.Sleep(2000);
            for (int i = 0; i < 9; i++)
            {
                driver.FindElement(By.CssSelector(".YwJvmF")).Click();
                Thread.Sleep(500);
            }

            if (driver.FindElement(By.CssSelector(".jmb20U > div:nth-child(1)")).Displayed)
            {
                driver.FindElement(By.CssSelector(".jmb20U > div:nth-child(1)")).Click();
                Console.WriteLine("Loggan fanns");
            }

            else
            {
                Console.WriteLine("Loggan finns inte");
            }

        }
    }
}
