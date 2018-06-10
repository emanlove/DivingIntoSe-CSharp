﻿using Lab_8.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab_8.Tests
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver driver;
        public LoginPage Login;

        public BaseTest()
        {}

        [SetUp]
        public void Setup(){
            this.driver = new ChromeDriver();
            this.Login = new LoginPage(this.driver);
        }

        [TearDown]
        public void Teardown(){
            this.driver.Quit();
        }
    }
}