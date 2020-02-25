using AmazonTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Example.SpecFlow.StepDefenitions
{
    [Binding]
    public class ProductSearchSteps
    {
        private IWebDriver driver;
        private ProductSearchPage _searchPage;
        private LenguageChangePage _lenguageChangePage;

        public ProductSearchSteps(IWebDriver driver)
        {   
            _searchPage = new ProductSearchPage(driver);
            _lenguageChangePage = new LenguageChangePage(driver);
        }           

        [When(@"I type the '(.*)' search text")]
        public void WhenITypeTheSearchText(string searchText)
        {
            _searchPage.EnterSearchText(searchText);
        }

        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
            _searchPage.ClickSearchButton();
        }

        [Then(@"The products that matched search text is displayed")]
        public void ThenTheProductsThatMatchedSearchTextIsDisplayed()
        {
            Assert.IsTrue(_searchPage.GetProductCounts() > 0);
        }

        [Then(@"The product is not found")]
        public void ThenTheProductIsNotFound()
        {
            var isNotFoundMessage = _searchPage.GetProductNotFoundMessage();
            Assert.IsTrue(isNotFoundMessage.Contains("No results for"));            
        }
    }
}
