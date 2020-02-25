using AmazonTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Amazon.Specflow.StepDefinitions
{
    [Binding]
    public class LenguageChangeSteps
    {
        private IWebDriver driver;
        private LenguageChangePage _lenguageChangePage;

        public LenguageChangeSteps(IWebDriver driver)
        {
            _lenguageChangePage = new LenguageChangePage(driver);
        }       

        [When(@"I click the change language option")]
        public void WhenIClickTheChangeLanguageOption()
        {
            _lenguageChangePage.ClickChangeLenguage();
        }
        
        [When(@"I select the '(.*)' language")]
        public void WhenISelectTheLanguage(string language)
        {
            _lenguageChangePage.SetLanguage(language);
        }

        [When(@"I click on save changes button")]
        public void WhenIClickOnSaveChangesButton()
        {
            _lenguageChangePage.ClickSaveChanges();
        }


        [Then(@"The site uses the language code '(.*)' selected")]
        public void ThenTheSiteUsesTheLanguageSelected(string languageCode)
        {
            Assert.IsTrue(_lenguageChangePage.GetSelectedLanguage().EndsWith(languageCode));
        }
    }
}
