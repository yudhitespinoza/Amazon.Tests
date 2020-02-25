using AmazonTests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Amazon.Specflow.StepDefinitions
{
    [Binding]
    public class CommonSteps
    {
        private IWebDriver driver;
        private ProductSearchPage _searchPage;
        private LenguageChangePage _lenguageChangePage;

        public CommonSteps(IWebDriver driver)
        {           
            _searchPage = new ProductSearchPage(driver);
            _lenguageChangePage = new LenguageChangePage(driver);
        }

        [Given(@"I have opened the amazon page")]
        public void GivenIHaveOpenedTheEbayPage()
        {
            _searchPage.GoToAmazonHomePage();
        }

        [Given(@"I set the language to English")]
        public void GivenISetTheLanguageToEnglish()
        {            
            _lenguageChangePage.SetEnglishLanguage();
        }
    }
}
