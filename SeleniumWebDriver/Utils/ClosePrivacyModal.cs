using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriver.Utils;

namespace SeleniumWebDriver.Utils
{
    internal static class ClosePrivacyModal
    {

        public static void Close(IWebDriver driver)
        {
            By privacyAgreeEl = By.CssSelector(".dbIJOc.dbIJOc .qc-cmp2-footer .qc-cmp2-summary-buttons button:last-child");

            try
            {
                WaitTimer.WaitTime(2000);
                var privacyAgreeBtn = driver.FindElement(privacyAgreeEl);
                privacyAgreeBtn.Click();
                WaitTimer.WaitTime(2000);
            }
            catch (Exception ex)
            {


            };
        }
    }
}
