using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System.Threading;

namespace Mobiletest
{
    class Program
    {
        static void Main(string[] args)
        {
            String appPath = @"c:\users\rajthegr8\documents\visual studio 2015\Projects\ConsoleApplication1\ConsoleApplication1\com.bt.bms.apk";
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("device", "Android");
            caps.SetCapability(CapabilityType.Platform, "Windows");
            caps.SetCapability("deviceName", "Android");
            caps.SetCapability("platformName", "Android");
            caps.SetCapability("app", appPath);

            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4723/wd/hub"), caps);

            Thread.Sleep(5000);

            //Close the pop-up ad.
            driver.Navigate().Back();

            //Click on Login button
            driver.FindElement(By.Id("com.bt.bms:id/btnLogin")).Click();

            //Enter email ID
            driver.FindElement(By.Id("com.bt.bms:id/edtemail")).Clear();
            driver.FindElement(By.Id("com.bt.bms:id/edtemail")).SendKeys("raj88syd@gmail.com");

            //Enter Password
            driver.FindElement(By.Id("com.bt.bms:id/edtpass")).Clear();
            driver.FindElement(By.Id("com.bt.bms:id/edtpass")).SendKeys("Garfieldb1");

            //Click on Submit button
            driver.FindElement(By.Id("com.bt.bms:id/signin")).Click();

            //Close any pop ups
            driver.Navigate().Back();

            //Close the app.
            driver.Quit();

        }
    }
}
