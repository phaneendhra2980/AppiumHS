using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using System;
using System.Security.Policy;

namespace AppiumHS
{
    public class Tests
    {
        IOSDriver<IOSElement> driver;


        [SetUp]
        public void Setup()
        {
            AppiumOptions caps = new AppiumOptions();
            caps.AddAdditionalCapability("deviceName", "iPhone 11");
            caps.AddAdditionalCapability("udid", "00008030-00092D891422802E");
            caps.AddAdditionalCapability("automationName", "XCUITest");
            caps.AddAdditionalCapability("platformVersion", "14.2");
            caps.AddAdditionalCapability("platformName", "iOS");
            caps.AddAdditionalCapability("bundleId", "com.apple.Preferences");

            driver = new IOSDriver<IOSElement>(
                   new Uri("https://dev-in-blr-0.headspin.io:7014/v0/f8498d3eaf244972872e12a231beac3a/wd/hub"), caps);


        }

        [Test]
        public void LaunchHealthApp()
        {
            IOSElement el1 = (IOSElement)driver.FindElementByAccessibilityId("Health");
            el1.Click();
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}