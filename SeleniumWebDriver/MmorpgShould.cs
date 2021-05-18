using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver
{
    public class MmorpgShould
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadMainPage()
        {
            using IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://mmorpg.org.pl/");
        }

        [Theory]
        [InlineData("https://mmorpg.org.pl/", "Darmowe MMORPG - spis gier MMO, MMOFPS, MMORPG 3d, MOBA")]
        [InlineData("https://forum.mmorpg.org.pl/", "Forum o grach MMO / MMORPG / MOBA")]
        [Trait("Category", "Check Title in Main Page and Forum")]
        public void CheckTitle(string page, string expectedTitle)
        {
            using IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(page);
            var title = driver.Title;
            Assert.Equal(expectedTitle, title);
        }

        [Theory]
        [InlineData("https://mmorpg.org.pl/", "Darmowe MMORPG - spis gier MMO, MMOFPS, MMORPG 3d, MOBA")]
        [Trait("Category", "Check Title in Main Page and Forum")]
        public void CheckTitleAfterRefresh(string page, string expectedTitle)
        {
            using IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(page);
            var title = driver.Title;
            Assert.Equal(expectedTitle, title);

            driver.Navigate().Refresh();
            title = driver.Title;
            Assert.Equal(expectedTitle, title);
            Assert.Equal(page, driver.Url);
        }
    }
}
