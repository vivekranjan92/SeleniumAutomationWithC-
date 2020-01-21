namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;


    // Menu class is used to create all the element present on the web-page
    // created same as we have created in the HomePage
    public class Menu
    {
        public Menu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        // Adding all the 6 elements present on the web-page with type IWebElement
        //  this is the Page Object Model (POM), where we add alol the menu items
        // to make use of these elements we have to go to our EntryPOint.cs class and instantiate our class
        [FindsBy(How = How.Id, Using = "menu-item-25")]
        public IWebElement Introduction { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-106")]
        public IWebElement Selectors { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-35")]
        public IWebElement SpecialElements { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-57")]
        public IWebElement TestCases { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-58")]
        public IWebElement TestScenarios { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-26")]
        public IWebElement About { get; set; }


    }
}
