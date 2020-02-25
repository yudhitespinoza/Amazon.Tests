using OpenQA.Selenium;

namespace AmazonTests.Pages
{
    public class LenguageChangePage
    {
        private IWebDriver _driver;

        public LenguageChangePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        private readonly string homeUrl = "https://www.amazon.com/";

        private IWebElement ChangeLanguage => _driver.FindElement(By.ClassName("icp-nav-link-inner"));
        private IWebElement EnglishLanguage => _driver.FindElement(By.XPath("//span[contains(text(),'English - EN')]"));
        private IWebElement SelectedLanguage => _driver.FindElement(By.ClassName("icp-nav-language"));
        private IWebElement SaveChanges => _driver.FindElement(By.Id("icp-btn-save"));

        private IWebElement GetLanguageOption(string lenguage)
        {
            return _driver.FindElement(By.XPath($"//span[contains(text(),'{lenguage}')]"));
        }

        public void ClickChangeLenguage()
        {
            ChangeLanguage.Click();
        }

        public void SetEnglishLanguage()
        {
            ClickChangeLenguage();
            EnglishLanguage.Click();
        }

        public void SetLanguage(string lenguage)
        {            
            GetLanguageOption(lenguage).Click();
        }

        public string GetSelectedLanguage()
        {
            return SelectedLanguage.Text;
        }

        public void ClickSaveChanges()
        {
            SaveChanges.Click();
        }

    }
}
