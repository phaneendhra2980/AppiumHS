using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using System;
using System.Security.Policy;

namespace AppiumHS
{
    public class AndroidHSTests
    {
        AndroidDriver<AndroidElement> driver;


        [SetUp]
        public void Setup()
        {
            AppiumOptions caps = new AppiumOptions();
            caps.AddAdditionalCapability("deviceName", "Pixel 2 XL");
            caps.AddAdditionalCapability("udid", "711KPXV0853522");
            caps.AddAdditionalCapability("automationName", "UiAutomator2");
            caps.AddAdditionalCapability("appPackage", "com.android.settings");
            caps.AddAdditionalCapability("platformName", "Android");
            caps.AddAdditionalCapability("appActivity", "com.android.settings.Settings");

            driver = new AndroidDriver<AndroidElement>(
                   new Uri("https://dev-in-blr-0.headspin.io:7005/v0/f8498d3eaf244972872e12a231beac3a/wd/hub"), caps);


        }

        [Test]
        public void ClickSoundApp_HelpIcon()
        {
            AndroidElement el1 = (AndroidElement)driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[6]/android.widget.RelativeLayout");
            el1.Click();
            AndroidElement el2 = (AndroidElement)driver.FindElementByAccessibilityId("Help & feedback");
            el2.Click();


        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}