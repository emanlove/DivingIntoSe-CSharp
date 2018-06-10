﻿using NUnit.Framework;
using OpenQA.Selenium;

namespace Lab_10.Pages
{
    public class DashboardPage : BasePage
    {

        private By WebSiteSelector = By.ClassName("tableWrapBlue");
        private By ConfigurationSecondary = By.CssSelector("input#Configuration");
        private By OptimalLenderSecondary = By.XPath("//input[contains(@name, 'Optimal Lender')]");

        public DashboardPage(IWebDriver driver) : base(driver)
        {
            Assert.That(Displayed(WebSiteSelector), "Website Selector is not present");
        }

        public ConfigurationPage EnterConfiguration()
        {
            Click(ConfigurationSecondary);
            return new ConfigurationPage(driver);
        }
    }
}