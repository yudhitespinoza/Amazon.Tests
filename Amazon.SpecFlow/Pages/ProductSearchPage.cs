using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace AmazonTests.Pages
{
    public class ProductSearchPage
    {
        private IWebDriver _driver;
        private LenguageChangePage _lenguageChangePage;

        public ProductSearchPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        private readonly string homeUrl = "https://www.amazon.com/";
      
        private IWebElement SearchTextBox => _driver.FindElement(By.Id("twotabsearchtextbox"));
        private IWebElement SearchButton => _driver.FindElement(By.ClassName("nav-search-submit"));
     
        private ReadOnlyCollection<IWebElement> ProductCards => _driver.FindElements(By.ClassName("s-include-content-margin"));
        private ReadOnlyCollection<IWebElement> ProductNotFoundMessages => _driver.FindElements(By.ClassName("a-size-medium"));

        public void GoToAmazonHomePage()
        {
            _driver.Navigate().GoToUrl(homeUrl);
        }       

        public void EnterSearchText(string searchText)
        {
            SearchTextBox.SendKeys(searchText);
        }

        public void ClickSearchButton()
        {
            SearchButton.Click();
        }

        public int GetProductCounts()
        {
            return ProductCards.Count;
        }

        public string GetProductNotFoundMessage()
        {
            return ProductNotFoundMessages[0].Text + ProductNotFoundMessages[1].Text;
        }
    }
}
