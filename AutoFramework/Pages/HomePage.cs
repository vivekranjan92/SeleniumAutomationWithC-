namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class HomePage
    {
        // making a constructor for every class we make 
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        // including all the elements available on the home page
        // we have 4 element on the home page, i.e. Header, SubHeader, Image and Headline
        // for adding any element we make use of FindsBy inside the square bracket
        // we make use of the how keyword to find the particular element using any locator.
        // we are using CssSelector here to find the element
        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > header > div.mh-container.mh-container-inner.mh-row.clearfix > div > a > div > div > h1")]
        // creating a property of type IWebElement
        public IWebElement Header { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > header > div.mh-container.mh-container-inner.mh-row.clearfix > div > a > div > div > h2")]
        public IWebElement SubHeader { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > div > p:nth-child(1) > a > img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > header > h1")]
        public IWebElement Headline { get; set; }
    }
}
