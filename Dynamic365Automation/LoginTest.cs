namespace Dynamic365Automation
{
    using System;
    using System.ComponentModel;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Edge;
    using OpenQA.Selenium.Firefox;

    using TechTalk.SpecFlow;

    /// <summary>
    /// The login test class
    /// </summary>
    [Binding]
    public sealed class LoginTest
    {
        /// <summary>
        /// The current webdriver instance
        /// </summary>
        private IWebDriver driver;

        /// <summary>
        /// Setting up the browser
        /// </summary>
        /// <param name="browserType">
        /// The browser type.
        /// </param>
        /// <exception cref="InvalidEnumArgumentException">
        /// Exception happens when the method is called with other value than Chrome | Edge | Firefox
        /// </exception>
        [Given(@"I am using '(Chrome|Edge|Firefox)'")]
        public void GivenIAmUsing(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    this.driver = new ChromeDriver();
                break;
                case BrowserType.Edge:
                    this.driver = new EdgeDriver();
                break;
                case BrowserType.Firefox:
                    this.driver = new FirefoxDriver();
                break;
                default:
                    throw new InvalidEnumArgumentException($"{browserType} is not a valid enum value. Please use: Chrome, Edge, Firefox");
            }

            this.driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// The tear down method which closes the driver instance and closes the browser.
        /// </summary>
        [AfterScenario]
        public void TearDown()
        {
            this.driver.Quit();
        }

        /// <summary>
        /// Navigate to main page and wait until it's loaded
        /// </summary>
        [Given(@"I am on the main login page")]
        public void GivenIAmOnTheMainLoginPage()
        {
            Uri mainSite = new Uri("https://re-gister.crm2.dynamics.com");
            this.driver.Navigate().GoToUrl(mainSite);
            WaitFor.PageLoad(this.driver);
        }

        /// <summary>
        /// Sending the login email to the login input field 
        /// </summary>
        /// <param name="email">
        /// The current email address
        /// </param>
        [When(@"I write in '(.*@*.\..*)' as my email address")]
        public void WhenIWriteInAsMyEmailAddress(string email)
        {
            By emailFieldLocator = By.XPath("//input[@type='email']");
            WaitFor.ToBeTrue(() => TestHelper.ElementVisible(this.driver, emailFieldLocator));

            this.driver.FindElement(emailFieldLocator).SendKeys(email);
        }

        /// <summary>
        /// Clicking the next button step
        /// </summary>
        [When(@"I click next button")]
        public void WhenIClickNextButton()
        {
            TestHelper.SubmitForm(this.driver);
        }

        /// <summary>
        /// Writing the password to the password field
        /// </summary>
        /// <param name="password">
        /// The current password
        /// </param>
        [When(@"I write '(.*)' as my password")]
        public void WhenIWriteAsMyPassword(string password)
        {
            By passwordFieldLocator = By.XPath("//input[@type='password']");
            WaitFor.ToBeTrue(() => TestHelper.ElementVisible(this.driver, passwordFieldLocator));

            this.driver.FindElement(passwordFieldLocator).SendKeys(password);
        }

        /// <summary>
        /// Clicking the Sign In button
        /// </summary>
        [When(@"I click sign in button")]
        public void WhenIClickSignInButton()
        {
            TestHelper.SubmitForm(this.driver);
        }

        /// <summary>
        /// Checking if the Remember login modal appears, 
        /// if yes clicking on the No button, 
        /// if doesn't appear just checking if we arrived on the main logged in page.
        /// </summary>
        [Then(@"I should arrive to the main logged in page")]
        public void ThenIShouldArriveToTheMainLoggedInPage()
        {
            try
            {
                // Checking if Remember login modal is visible, if yes handle it
                Assert.IsTrue(WaitFor.ToBeTrue(() => TestHelper.ElementVisible(this.driver, By.CssSelector("#idBtn_Back")), 3));

                IWebElement dontRememberLoginButton = this.driver.FindElement(By.CssSelector("#idBtn_Back"));
                dontRememberLoginButton.Click();

                // Waiting for the page to load, and check if we arrived at the logged in page.
                WaitFor.PageLoad(this.driver);
                WaitFor.ToBeTrue(() => TestHelper.ElementVisible(this.driver, By.CssSelector("#lpathRuntimeOverlay")));
            }
            catch (AssertionException assertionException)
            {
                // Catching exception if Remember login screen is not appeared
                // Assert that we arrived at the main logged in page
                Console.WriteLine(assertionException);
                WaitFor.PageLoad(this.driver);
                WaitFor.ToBeTrue(() => TestHelper.ElementVisible(this.driver, By.CssSelector("#lpathRuntimeOverlay")));
            }
        }
    }
}