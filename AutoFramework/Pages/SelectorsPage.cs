﻿namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class SelectorsPage
    {
        public SelectorsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.clearfix.post-111.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div.mh-loop-content.clearfix > header > h3 > a")]
        public IWebElement NameHeadline { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.clearfix.post-111.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div.mh-loop-thumb > a > img")]
        public IWebElement NameFeaturedImage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.clearfix.post-111.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div.mh-loop-content.clearfix > div > div > p")]
        public IWebElement NameSampleText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.clearfix.post-111.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div.mh-loop-content.clearfix > header > div > span.mh-meta-date.updated")]
        public IWebElement NamePublishedDate { get; set; }


    }
}
