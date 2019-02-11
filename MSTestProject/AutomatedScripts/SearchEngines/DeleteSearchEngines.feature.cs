// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MSTestProject.AutomatedScripts.SearchEngines
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class DeleteSearchEnginesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "DeleteSearchEngines.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Delete Search Engines", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Delete Search Engines")))
            {
                global::MSTestProject.AutomatedScripts.SearchEngines.DeleteSearchEnginesFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
  #line 5
    testRunner.Given("I go to the VSMC site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
    testRunner.And("I should see the VSMC login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
    testRunner.And("I successfully login as a SYSADMIN", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete search engine by icon - yes (uid:3f4237d8-6cd2-4932-84db-58746e91d5f0)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Delete Search Engines")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AUTO_READY")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SEARCH_ENGINE")]
        public virtual void DeleteSearchEngineByIcon_YesUid3F4237D8_6Cd2_4932_84Db_58746E91D5F0()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete search engine by icon - yes (uid:3f4237d8-6cd2-4932-84db-58746e91d5f0)", null, new string[] {
                        "AUTO_READY",
                        "SEARCH_ENGINE"});
#line 10
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
  this.FeatureBackground();
#line 11
    testRunner.Then("I add my search engine if it does not already exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
    testRunner.Then("I search for my search engine by Name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
    testRunner.And("I should see my search engine in the list of search engines", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
    testRunner.When("I click the trash can associated with my search engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
    testRunner.Then("I should see the Delete Confirmation modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
    testRunner.And("I click Yes on the Delete Confirmation modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
    testRunner.And("I should see Delete toaster confirmation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
    testRunner.And("I should not see my search engine in the list of search engines", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete search engine by icon - no (uid:beb6f288-e3af-4b6e-aa8c-2fa5ab53d2de)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Delete Search Engines")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AUTO_READY")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SEARCH_ENGINE")]
        public virtual void DeleteSearchEngineByIcon_NoUidBeb6F288_E3Af_4B6E_Aa8C_2Fa5Ab53D2De()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete search engine by icon - no (uid:beb6f288-e3af-4b6e-aa8c-2fa5ab53d2de)", null, new string[] {
                        "AUTO_READY",
                        "SEARCH_ENGINE"});
#line 21
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
  this.FeatureBackground();
#line 22
    testRunner.And("I add my search engine if it does not already exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
    testRunner.Then("I search for my search engine by Name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
    testRunner.And("I should see my search engine in the list of search engines", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
    testRunner.When("I click the trash can associated with my search engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
    testRunner.Then("I should see the Delete Confirmation modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
    testRunner.And("I click No on the Delete Confirmation modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
    testRunner.And("I should see my search engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete search engine by button - yes (uid:23f02b0c-5872-458f-8b76-246f1d639f62)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Delete Search Engines")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AUTO_READY")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SEARCH_ENGINE")]
        public virtual void DeleteSearchEngineByButton_YesUid23F02B0C_5872_458F_8B76_246F1D639F62()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete search engine by button - yes (uid:23f02b0c-5872-458f-8b76-246f1d639f62)", null, new string[] {
                        "AUTO_READY",
                        "SEARCH_ENGINE"});
#line 31
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
  this.FeatureBackground();
#line 32
    testRunner.Then("I add my search engine if it does not already exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
    testRunner.Then("I search for my search engine by Name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
    testRunner.And("I should see my search engine in the list of search engines", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
    testRunner.And("I should see the Delete Selected button on the search engines page disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
    testRunner.And("I select my search engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
    testRunner.And("I click the Delete Selected button on the search engine page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
    testRunner.Then("I should see the Delete Confirmation modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
    testRunner.And("I click Yes on the Delete Confirmation modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
    testRunner.And("I should see Delete toaster confirmation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
    testRunner.And("I should not see my search engine in the list of search engines", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete search engine by button - no (uid:e6ad8020-86c7-4a7d-8cbd-157152e53599)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Delete Search Engines")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("AUTO_READY")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SEARCH_ENGINE")]
        public virtual void DeleteSearchEngineByButton_NoUidE6Ad8020_86C7_4A7D_8Cbd_157152E53599()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete search engine by button - no (uid:e6ad8020-86c7-4a7d-8cbd-157152e53599)", null, new string[] {
                        "AUTO_READY",
                        "SEARCH_ENGINE"});
#line 44
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
  this.FeatureBackground();
#line 45
    testRunner.Then("I add my search engine if it does not already exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
    testRunner.Then("I search for my search engine by Name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
    testRunner.And("I should see my search engine in the list of search engines", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
    testRunner.And("I should see the Delete Selected button on the search engines page disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
    testRunner.And("I select my search engine", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
    testRunner.And("I click the Delete Selected button on the search engine page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
    testRunner.Then("I should see the Delete Confirmation modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
    testRunner.And("I click No on the Delete Confirmation modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
    testRunner.And("I should not see the Delete toaster confirmation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
    testRunner.And("I should see my search engine in the list of search engines", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion