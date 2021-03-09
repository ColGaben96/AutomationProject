using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace GoogleMapsAutomationTry
{
    /// <summary>
    /// Idea is to travel between some streets in Bogotá
    /// </summary>
    [TestClass]
    public class GoogleMaps
    {
        private IWebDriver driver = new ChromeDriver("C:\\Program Files\\Google\\Chrome\\Application");
        [TestMethod]
        public void FindSomewhereBogota()
        {
            driver.Navigate().GoToUrl("https://www.google.com/maps");
            var locationText = driver.FindElement(By.XPath("//*[@id='searchboxinput']"));
            locationText.Click();
            locationText.SendKeys("Centro Comercial Palatino");
            locationText.SendKeys(Keys.Enter);
            Thread.Sleep(5 * 1000);
            var map = driver.FindElement(By.XPath("/html/body/jsl/div[3]/div[9]/div[8]/div/div[1]/div/div/div[5]/div[1]/div/button"));
            map.Click();
            Thread.Sleep(2 * 1000);
            var origin = driver.FindElement(By.XPath("/html/body/jsl/div[3]/div[9]/div[3]/div[1]/div[2]/div/div[3]/div[1]/div[1]/div[2]/div/div/input"));
            origin.Click();
            Thread.Sleep(2 * 1000);
            origin.SendKeys("Universidad El Bosque");
            var search = driver.FindElement(By.XPath("/html/body/jsl/div[3]/div[9]/div[3]/div[1]/div[2]/div/div[3]/div[1]/div[1]/div[2]/button[1]"));
            search.Click();
            Thread.Sleep(2 * 1000);
            var walkingMode = driver.FindElement(By.XPath("/html/body/jsl/div[3]/div[9]/div[3]/div[1]/div[2]/div/div[2]/div/div/div[1]/div[4]/button/img"));
            walkingMode.Click();
            Thread.Sleep(2 * 1000);
            var directions = driver.FindElement(By.XPath("/html/body/jsl/div[3]/div[9]/div[8]/div/div[1]/div/div/div[5]/div/div/div[3]"));
            directions.Click();
            Thread.Sleep(2 * 1000);
            var firstDirection = driver.FindElement(By.XPath("/html/body/jsl/div[3]/div[9]/div[8]/div/div[1]/div/div/div[5]/div/div/div[1]/div/div[2]/div[3]/div[1]/div[2]/div/div/div[1]/div/div[1]/div[2]/div"));
            firstDirection.Click();
            Thread.Sleep(2 * 1000);
            var secondDirection = driver.FindElement(By.XPath("/html/body/jsl/div[3]/div[9]/div[8]/div/div[1]/div/div/div[5]/div/div/div[1]/div/div[2]/div[3]/div[1]/div[2]/div/div/div[2]/div/div[1]/div[2]/div"));
            secondDirection.Click();
            Thread.Sleep(2 * 1000);
            var thirdDirection = driver.FindElement(By.XPath("/html/body/jsl/div[3]/div[9]/div[8]/div/div[1]/div/div/div[5]/div/div/div[1]/div/div[2]/div[3]/div[1]/div[2]/div/div/div[3]/div/div[1]/div[2]/div"));
            thirdDirection.Click();
            Thread.Sleep(2 * 1000);
            var fourthDirection = driver.FindElement(By.XPath("/html/body/jsl/div[3]/div[9]/div[8]/div/div[1]/div/div/div[5]/div/div/div[1]/div/div[2]/div[3]/div[1]/div[2]/div/div/div[4]/div/div[1]/div[2]/div"));
            fourthDirection.Click();
            Thread.Sleep(2 * 1000);
            driver.Close();
        }
    }
}
