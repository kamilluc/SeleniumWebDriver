using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriver.Utils;

namespace SeleniumWebDriver
{
    public class SearchGameeShould
    {
        private readonly By searchEl = By.CssSelector(".game-search .btn-search");
        private readonly By privacyAgreeEl = By.CssSelector(".dbIJOc.dbIJOc .qc-cmp2-footer .qc-cmp2-summary-buttons button:last-child");

        [Fact]
        [Trait("Category", "Search Game")]
        public void SearchGameWorks()
        {
            using IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://mmorpg.org.pl/");
            //try
            //{
            //    WaitTimer.WaitTime(2000);
            //    var privacyAgreeBtn = driver.FindElement(privacyAgreeEl);
            //    privacyAgreeBtn.Click();
            //    WaitTimer.WaitTime(2000);
            //}
            //catch (Exception ex)
            //{


            //}
            //finally
            //{
            ClosePrivacyModal.Close(driver);
            var searchBtn = driver.FindElement(searchEl);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView()", searchBtn);
            WaitTimer.WaitTime();
            searchBtn.Click();
            WaitTimer.WaitTime();

            //}




        }
    }
}
