﻿using System;
using Lab_9.Helper;
using OpenQA.Selenium;

namespace Lab_9.Pages
{
    public class LoanBasePage : BasePage
    {
        protected By BaseLoanAmountField = By.Id("BaseLoanAmount");
        protected By EstimatedValueField = By.Id("SalesAmount");
        protected By BorrowerFICOField = By.Id("CustomLenderField1");
        protected By DTIRatioField = By.Id("DTIRatio");
        protected By CountySelect = By.Id("County");
        protected By SubmitButton = By.Id("btnSubmit_search_bottom");
        private String PageTitle = "Product Search";

        
        /// <summary>
        /// Constructor for Lender Search Page
        ///
        /// The alternative is to make a BaseLoanFormPAge and then have this and the LockPage extend it with their details
        /// </summary>
        /// <param name="driver">Selenium WebDriver</param>
        /// <param name="child">if true do not run the assert message</param>
        public LoanBasePage(IWebDriver driver) : base(driver)
        {
           
        }
       

        public LoanBasePage SearchFor(Loan Loan)
        {
            EnterLoanAmount(Loan.BaseLoanAmount).EnterEstimatedValue(Loan.EstimatedValue).EnterBorrowerFICO(Loan.BorrowerFICO)
                .EnterDTIRatio(Loan.DTIRatio).SelectCounty(Loan.County);

            
            return new LenderSearchPage(driver);

        }

        public LenderSearchResultsPage Search()
        {
            
            Click(SubmitButton);
            return new LenderSearchResultsPage(driver);
        }
        
        public LoanBasePage EnterLoanAmount(int BaseLoanAmount)
        {
            Type(BaseLoanAmount.ToString(), BaseLoanAmountField);
            return this;
        }

        public LoanBasePage EnterEstimatedValue(int EstimatedValue)
        {
            Type(EstimatedValue.ToString(),EstimatedValueField);
            return this;
        }

        public LoanBasePage EnterBorrowerFICO(int BorrowerFICO)
        {
            Type(BorrowerFICO.ToString(), BorrowerFICOField);
            return this;
        }
        public LoanBasePage EnterDTIRatio(int DTIRatio)
        {
            Type(DTIRatio.ToString(), DTIRatioField);
            return this;
        }

        public LoanBasePage SelectCounty(Loan.CountyOptions County)
        {
            SelectOptionText(County.ToString(), CountySelect);
            return this;
        }
    }
}