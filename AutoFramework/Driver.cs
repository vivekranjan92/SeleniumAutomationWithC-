namespace AutoFramework
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;


    // Only purpose of this driver class is to provide us our driver, so, that our driver is accessible anywhere
    // we will make it static so that we do not have to instantiate it everytime we use it
    public static class Driver
    {
        public static IWebDriver driver { get; set; }

        public static void WaitForElementUpTo(int seconds = 5)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }
    }
}
