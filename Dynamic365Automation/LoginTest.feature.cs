﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Dynamic365Automation
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("LoginTest")]
    public partial class LoginTestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LoginTest.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "LoginTest", "\tIn order to see that everything working well during the login process\r\n\tAs a use" +
                    "r\r\n\tI want to be able to log in", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login with demo user")]
        [NUnit.Framework.CategoryAttribute("login")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.TestCaseAttribute("Chrome", null)]
        [NUnit.Framework.TestCaseAttribute("Edge", null)]
        [NUnit.Framework.TestCaseAttribute("Firefox", null)]
        public virtual void LoginWithDemoUser(string browser, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "login",
                    "smoke"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login with demo user", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given(string.Format("I am using \'{0}\'", browser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.Given("I am on the main login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When("I write in \'peter.halassy@re-gister.com\' as my email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
    testRunner.And("I click next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
    testRunner.And("I write \'P@ssword\' as my password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
    testRunner.And("I click sign in button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
    testRunner.Then("I should arrive to the main logged in page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
