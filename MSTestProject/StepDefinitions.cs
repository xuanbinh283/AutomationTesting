namespace Example {
    using System;
    using TechTalk.SpecFlow;

    [Binding]
    public class StepDefinitions {

        public Actionwords Actionwords = new Actionwords();

        [Given("^I click the Log in button$"), When("^I click the Log in button$"), Then("^I click the Log in button$")]
        public void IClickTheLogInButton() {
            Actionwords.IClickTheLogInButton();
        }


        [Given("^I go to the VSMC site$"), When("^I go to the VSMC site$"), Then("^I go to the VSMC site$")]
        public void IGoToTheVSMCSite() {
            Actionwords.IGoToTheVSMCSite();
        }





        [Given("^I should see my search engine$"), When("^I should see my search engine$"), Then("^I should see my search engine$")]
        public void IShouldSeeMySearchEngine() {
            Actionwords.IShouldSeeMySearchEngine();
        }


        [Given("^I count the number of search engines on the page$"), When("^I count the number of search engines on the page$"), Then("^I count the number of search engines on the page$")]
        public void ICountTheNumberOfSearchEnginesOnThePage() {
            Actionwords.ICountTheNumberOfSearchEnginesOnThePage();
        }



        [Given("^I search for my search engine by Name$"), When("^I search for my search engine by Name$"), Then("^I search for my search engine by Name$")]
        public void ISearchForMySearchEngineByName() {
            Actionwords.ISearchForMySearchEngineByName();
        }




        [Given("^I select my search engine$"), When("^I select my search engine$"), Then("^I select my search engine$")]
        public void ISelectMySearchEngine() {
            Actionwords.ISelectMySearchEngine();
        }




















        [Given("^I refresh the page$"), When("^I refresh the page$"), Then("^I refresh the page$")]
        public void IRefreshThePage() {
            Actionwords.IRefreshThePage();
        }

        [Given("^I log out of the system$"), When("^I log out of the system$"), Then("^I log out of the system$")]
        public void ILogOutOfTheSystem() {
            Actionwords.ILogOutOfTheSystem();
        }

        [Given("^I should see the VSMC login page$"), When("^I should see the VSMC login page$"), Then("^I should see the VSMC login page$")]
        public void IShouldSeeTheVSMCLoginPage() {
            Actionwords.IShouldSeeTheVSMCLoginPage();
        }

        [Given("^I should see the toaster confirmation that the login has failed$"), When("^I should see the toaster confirmation that the login has failed$"), Then("^I should see the toaster confirmation that the login has failed$")]
        public void IShouldSeeTheToasterConfirmationThatTheLoginHasFailed() {
            Actionwords.IShouldSeeTheToasterConfirmationThatTheLoginHasFailed();
        }

        [Given("^I should see the Search Engines page$"), When("^I should see the Search Engines page$"), Then("^I should see the Search Engines page$")]
        public void IShouldSeeTheSearchEnginesPage() {
            Actionwords.IShouldSeeTheSearchEnginesPage();
        }


        [Given("^I enter an email address of a SYSTEM_ADMIN$"), When("^I enter an email address of a SYSTEM_ADMIN$"), Then("^I enter an email address of a SYSTEM_ADMIN$")]
        public void IEnterAnEmailAddressOfASYSTEMADMIN() {
            Actionwords.IEnterAnEmailAddressOfASYSTEMADMIN();
        }

        [Given("^I press tab on the email address field$"), When("^I press tab on the email address field$"), Then("^I press tab on the email address field$")]
        public void IPressTabOnTheEmailAddressField() {
            Actionwords.IPressTabOnTheEmailAddressField();
        }

        [Given("^I should see the Email is required message$"), When("^I should see the Email is required message$"), Then("^I should see the Email is required message$")]
        public void IShouldSeeTheEmailIsRequiredMessage() {
            Actionwords.IShouldSeeTheEmailIsRequiredMessage();
        }

        [Given("^I should see the Password is required message$"), When("^I should see the Password is required message$"), Then("^I should see the Password is required message$")]
        public void IShouldSeeThePasswordIsRequiredMessage() {
            Actionwords.IShouldSeeThePasswordIsRequiredMessage();
        }

        [Given("^The Log in button should be disabled$"), When("^The Log in button should be disabled$"), Then("^The Log in button should be disabled$")]
        public void TheLogInButtonShouldBeDisabled() {
            Actionwords.TheLogInButtonShouldBeDisabled();
        }

        [Given("^The Log in button should be enabled$"), When("^The Log in button should be enabled$"), Then("^The Log in button should be enabled$")]
        public void TheLogInButtonShouldBeEnabled() {
            Actionwords.TheLogInButtonShouldBeEnabled();
        }

        [Given("^I enter a password of SYSTEM_ADMIN_PASSWORD$"), When("^I enter a password of SYSTEM_ADMIN_PASSWORD$"), Then("^I enter a password of SYSTEM_ADMIN_PASSWORD$")]
        public void IEnterAPasswordOfSYSTEMADMINPASSWORD() {
            Actionwords.IEnterAPasswordOfSYSTEMADMINPASSWORD();
        }

        [Given("^I enter a password of BAD_PASSWORD$"), When("^I enter a password of BAD_PASSWORD$"), Then("^I enter a password of BAD_PASSWORD$")]
        public void IEnterAPasswordOfBADPASSWORD() {
            Actionwords.IEnterAPasswordOfBADPASSWORD();
        }

        [Given("^I enter an email address of SUPER _USER$"), When("^I enter an email address of SUPER _USER$"), Then("^I enter an email address of SUPER _USER$")]
        public void IEnterAnEmailAddressOfSUPERUSER() {
            Actionwords.IEnterAnEmailAddressOfSUPERUSER();
        }

        [Given("^I enter a password of SUPER_USER_PASSWORD$"), When("^I enter a password of SUPER_USER_PASSWORD$"), Then("^I enter a password of SUPER_USER_PASSWORD$")]
        public void IEnterAPasswordOfSUPERUSERPASSWORD() {
            Actionwords.IEnterAPasswordOfSUPERUSERPASSWORD();
        }

        [Given("^I clear the email address field$"), When("^I clear the email address field$"), Then("^I clear the email address field$")]
        public void IClearTheEmailAddressField() {
            Actionwords.IClearTheEmailAddressField();
        }

        [Given("^I clear the password field$"), When("^I clear the password field$"), Then("^I clear the password field$")]
        public void IClearThePasswordField() {
            Actionwords.IClearThePasswordField();
        }

        [Given("^I unsuccessfully login as a SYSADMIN$"), When("^I unsuccessfully login as a SYSADMIN$"), Then("^I unsuccessfully login as a SYSADMIN$")]
        public void IUnsuccessfullyLoginAsASYSADMIN() {
            Actionwords.IUnsuccessfullyLoginAsASYSADMIN();
        }

        [Given("^I successfully login as a SYSADMIN$"), When("^I successfully login as a SYSADMIN$"), Then("^I successfully login as a SYSADMIN$")]
        public void ISuccessfullyLoginAsASYSADMIN() {
            Actionwords.ISuccessfullyLoginAsASYSADMIN();
        }

        [Given("^I enter an email address of BAD_EMAIL$"), When("^I enter an email address of BAD_EMAIL$"), Then("^I enter an email address of BAD_EMAIL$")]
        public void IEnterAnEmailAddressOfBADEMAIL() {
            Actionwords.IEnterAnEmailAddressOfBADEMAIL();
        }

        [Given("^I should see the message \"(.*)\"$"), When("^I should see the message \"(.*)\"$"), Then("^I should see the message \"(.*)\"$")]
        public void IShouldSeeTheMessageTheScreenText(string theScreenText) {
            Actionwords.IShouldSeeTheMessageTheScreenText(theScreenText);
        }

        [Given("^I enter a password of SHORT_PASSWORD$"), When("^I enter a password of SHORT_PASSWORD$"), Then("^I enter a password of SHORT_PASSWORD$")]
        public void IEnterAPasswordOfSHORTPASSWORD() {
            Actionwords.IEnterAPasswordOfSHORTPASSWORD();
        }

        [Given("^I click the Add Search Engine button$"), When("^I click the Add Search Engine button$"), Then("^I click the Add Search Engine button$")]
        public void IClickTheAddSearchEngineButton() {
            Actionwords.IClickTheAddSearchEngineButton();
        }

        [Given("^I should see the Add Search Engine details screen$"), When("^I should see the Add Search Engine details screen$"), Then("^I should see the Add Search Engine details screen$")]
        public void IShouldSeeTheAddSearchEngineDetailsScreen() {
            Actionwords.IShouldSeeTheAddSearchEngineDetailsScreen();
        }

        [Given("^I enter a random automated search engine name$"), When("^I enter a random automated search engine name$"), Then("^I enter a random automated search engine name$")]
        public void IEnterARandomAutomatedSearchEngineName() {
            Actionwords.IEnterARandomAutomatedSearchEngineName();
        }

        [Given("^I verify that the Key Prefix is set to STANDARD_KEY$"), When("^I verify that the Key Prefix is set to STANDARD_KEY$"), Then("^I verify that the Key Prefix is set to STANDARD_KEY$")]
        public void IVerifyThatTheKeyPrefixIsSetToSTANDARDKEY() {
            Actionwords.IVerifyThatTheKeyPrefixIsSetToSTANDARDKEY();
        }

        [Given("^I enter a description of \"(.*)\"$"), When("^I enter a description of \"(.*)\"$"), Then("^I enter a description of \"(.*)\"$")]
        public void IEnterADescriptionOfMyDescription(string myDescription) {
            Actionwords.IEnterADescriptionOfMyDescription(myDescription);
        }

        [Given("^I click the Save button on the search engine details page$"), When("^I click the Save button on the search engine details page$"), Then("^I click the Save button on the search engine details page$")]
        public void IClickTheSaveButtonOnTheSearchEngineDetailsPage() {
            Actionwords.IClickTheSaveButtonOnTheSearchEngineDetailsPage();
        }

        [Given("^I should see the Add Successful toaster confirmation$"), When("^I should see the Add Successful toaster confirmation$"), Then("^I should see the Add Successful toaster confirmation$")]
        public void IShouldSeeTheAddSuccessfulToasterConfirmation() {
            Actionwords.IShouldSeeTheAddSuccessfulToasterConfirmation();
        }

        [Given("^I should see my search engine in the list of search engines$"), When("^I should see my search engine in the list of search engines$"), Then("^I should see my search engine in the list of search engines$")]
        public void IShouldSeeMySearchEngineInTheListOfSearchEngines() {
            Actionwords.IShouldSeeMySearchEngineInTheListOfSearchEngines();
        }

        [Given("^I should see my search engine name$"), When("^I should see my search engine name$"), Then("^I should see my search engine name$")]
        public void IShouldSeeMySearchEngineName() {
            Actionwords.IShouldSeeMySearchEngineName();
        }

        [Given("^I should see the key prefixed by STANDARD_KEY$"), When("^I should see the key prefixed by STANDARD_KEY$"), Then("^I should see the key prefixed by STANDARD_KEY$")]
        public void IShouldSeeTheKeyPrefixedBySTANDARDKEY() {
            Actionwords.IShouldSeeTheKeyPrefixedBySTANDARDKEY();
        }

        [Given("^I should see a document count of 0$"), When("^I should see a document count of 0$"), Then("^I should see a document count of 0$")]
        public void IShouldSeeADocumentCountOf0() {
            Actionwords.IShouldSeeADocumentCountOf0();
        }

        [Given("^I should see a Last Updated timestamp of current time$"), When("^I should see a Last Updated timestamp of current time$"), Then("^I should see a Last Updated timestamp of current time$")]
        public void IShouldSeeALastUpdatedTimestampOfCurrentTime() {
            Actionwords.IShouldSeeALastUpdatedTimestampOfCurrentTime();
        }

        [Given("^I should see a By field populated with SYSADMIN$"), When("^I should see a By field populated with SYSADMIN$"), Then("^I should see a By field populated with SYSADMIN$")]
        public void IShouldSeeAByFieldPopulatedWithSYSADMIN() {
            Actionwords.IShouldSeeAByFieldPopulatedWithSYSADMIN();
        }

        [Given("^I should see the Edit icon for the search engine$"), When("^I should see the Edit icon for the search engine$"), Then("^I should see the Edit icon for the search engine$")]
        public void IShouldSeeTheEditIconForTheSearchEngine() {
            Actionwords.IShouldSeeTheEditIconForTheSearchEngine();
        }

        [Given("^I should see the Delete icon for the search engine$"), When("^I should see the Delete icon for the search engine$"), Then("^I should see the Delete icon for the search engine$")]
        public void IShouldSeeTheDeleteIconForTheSearchEngine() {
            Actionwords.IShouldSeeTheDeleteIconForTheSearchEngine();
        }

        [Given("^The key should contain \"(.*)\" characters$"), When("^The key should contain \"(.*)\" characters$"), Then("^The key should contain \"(.*)\" characters$")]
        public void TheKeyShouldContainCharCountCharacters(string charCount) {
            Actionwords.TheKeyShouldContainCharCountCharacters(charCount);
        }

        [Given("^I should see the search result of \"(.*)\"$"), When("^I should see the search result of \"(.*)\"$"), Then("^I should see the search result of \"(.*)\"$")]
        public void IShouldSeeTheSearchResultOfP1(string p1) {
            Actionwords.IShouldSeeTheSearchResultOfP1(p1);
        }

        [Given("^I clear the search engine box$"), When("^I clear the search engine box$"), Then("^I clear the search engine box$")]
        public void IClearTheSearchEngineBox() {
            Actionwords.IClearTheSearchEngineBox();
        }

        [Given("^I should see Display 1-count of total on the page$"), When("^I should see Display 1-count of total on the page$"), Then("^I should see Display 1-count of total on the page$")]
        public void IShouldSeeDisplay1countOfTotalOnThePage() {
            Actionwords.IShouldSeeDisplay1countOfTotalOnThePage();
        }

        [Given("^I click the trash can associated with my search engine$"), When("^I click the trash can associated with my search engine$"), Then("^I click the trash can associated with my search engine$")]
        public void IClickTheTrashCanAssociatedWithMySearchEngine() {
            Actionwords.IClickTheTrashCanAssociatedWithMySearchEngine();
        }

        [Given("^I should see the Delete Confirmation modal$"), When("^I should see the Delete Confirmation modal$"), Then("^I should see the Delete Confirmation modal$")]
        public void IShouldSeeTheDeleteConfirmationModal() {
            Actionwords.IShouldSeeTheDeleteConfirmationModal();
        }

        [Given("^I click Yes on the Delete Confirmation modal$"), When("^I click Yes on the Delete Confirmation modal$"), Then("^I click Yes on the Delete Confirmation modal$")]
        public void IClickYesOnTheDeleteConfirmationModal() {
            Actionwords.IClickYesOnTheDeleteConfirmationModal();
        }

        [Given("^I should see Delete toaster confirmation$"), When("^I should see Delete toaster confirmation$"), Then("^I should see Delete toaster confirmation$")]
        public void IShouldSeeDeleteToasterConfirmation() {
            Actionwords.IShouldSeeDeleteToasterConfirmation();
        }

        [Given("^I should not see my search engine in the list of search engines$"), When("^I should not see my search engine in the list of search engines$"), Then("^I should not see my search engine in the list of search engines$")]
        public void IShouldNotSeeMySearchEngineInTheListOfSearchEngines() {
            Actionwords.IShouldNotSeeMySearchEngineInTheListOfSearchEngines();
        }

        [Given("^I click No on the Delete Confirmation modal$"), When("^I click No on the Delete Confirmation modal$"), Then("^I click No on the Delete Confirmation modal$")]
        public void IClickNoOnTheDeleteConfirmationModal() {
            Actionwords.IClickNoOnTheDeleteConfirmationModal();
        }

        [Given("^I add my search engine if it does not already exist$"), When("^I add my search engine if it does not already exist$"), Then("^I add my search engine if it does not already exist$")]
        public void IAddMySearchEngineIfItDoesNotAlreadyExist() {
            Actionwords.IAddMySearchEngineIfItDoesNotAlreadyExist();
        }

        [Given("^I click the Admin drop-down$"), When("^I click the Admin drop-down$"), Then("^I click the Admin drop-down$")]
        public void IClickTheAdminDropdown() {
            Actionwords.IClickTheAdminDropdown();
        }

        [Given("^I select the Users entry in the Admin drop-down$"), When("^I select the Users entry in the Admin drop-down$"), Then("^I select the Users entry in the Admin drop-down$")]
        public void ISelectTheUsersEntryInTheAdminDropdown() {
            Actionwords.ISelectTheUsersEntryInTheAdminDropdown();
        }

        [Given("^I should see the Users main page$"), When("^I should see the Users main page$"), Then("^I should see the Users main page$")]
        public void IShouldSeeTheUsersMainPage() {
            Actionwords.IShouldSeeTheUsersMainPage();
        }

        [Given("^I click the Add User button$"), When("^I click the Add User button$"), Then("^I click the Add User button$")]
        public void IClickTheAddUserButton() {
            Actionwords.IClickTheAddUserButton();
        }

        [Given("^I enter my user's first name$"), When("^I enter my user's first name$"), Then("^I enter my user's first name$")]
        public void IEnterMyUsersFirstName() {
            Actionwords.IEnterMyUsersFirstName();
        }

        [Given("^I enter my user's last name$"), When("^I enter my user's last name$"), Then("^I enter my user's last name$")]
        public void IEnterMyUsersLastName() {
            Actionwords.IEnterMyUsersLastName();
        }

        [Given("^I enter my user's email$"), When("^I enter my user's email$"), Then("^I enter my user's email$")]
        public void IEnterMyUsersEmail() {
            Actionwords.IEnterMyUsersEmail();
        }

        [Given("^I enter my user's password in the Password field$"), When("^I enter my user's password in the Password field$"), Then("^I enter my user's password in the Password field$")]
        public void IEnterMyUsersPasswordInThePasswordField() {
            Actionwords.IEnterMyUsersPasswordInThePasswordField();
        }

        [Given("^I enter my user's password in the Confirm Password field$"), When("^I enter my user's password in the Confirm Password field$"), Then("^I enter my user's password in the Confirm Password field$")]
        public void IEnterMyUsersPasswordInTheConfirmPasswordField() {
            Actionwords.IEnterMyUsersPasswordInTheConfirmPasswordField();
        }

        [Given("^I should see the Active checkbox is already checked$"), When("^I should see the Active checkbox is already checked$"), Then("^I should see the Active checkbox is already checked$")]
        public void IShouldSeeTheActiveCheckboxIsAlreadyChecked() {
            Actionwords.IShouldSeeTheActiveCheckboxIsAlreadyChecked();
        }

        [Given("^I check the Super User checkbox$"), When("^I check the Super User checkbox$"), Then("^I check the Super User checkbox$")]
        public void ICheckTheSuperUserCheckbox() {
            Actionwords.ICheckTheSuperUserCheckbox();
        }

        [Given("^I click the Add button on the Add User details page$"), When("^I click the Add button on the Add User details page$"), Then("^I click the Add button on the Add User details page$")]
        public void IClickTheAddButtonOnTheAddUserDetailsPage() {
            Actionwords.IClickTheAddButtonOnTheAddUserDetailsPage();
        }

        [Given("^I search for my user by their email address$"), When("^I search for my user by their email address$"), Then("^I search for my user by their email address$")]
        public void ISearchForMyUserByTheirEmailAddress() {
            Actionwords.ISearchForMyUserByTheirEmailAddress();
        }

        [Given("^I should see my user in the list of users$"), When("^I should see my user in the list of users$"), Then("^I should see my user in the list of users$")]
        public void IShouldSeeMyUserInTheListOfUsers() {
            Actionwords.IShouldSeeMyUserInTheListOfUsers();
        }

        [Given("^The Full Name field should have my user lastname, firstname$"), When("^The Full Name field should have my user lastname, firstname$"), Then("^The Full Name field should have my user lastname, firstname$")]
        public void TheFullNameFieldShouldHaveMyUserLastnameFirstname() {
            Actionwords.TheFullNameFieldShouldHaveMyUserLastnameFirstname();
        }

        [Given("^The Email field should be my user's email$"), When("^The Email field should be my user's email$"), Then("^The Email field should be my user's email$")]
        public void TheEmailFieldShouldBeMyUsersEmail() {
            Actionwords.TheEmailFieldShouldBeMyUsersEmail();
        }

        [Given("^The Super User field should be set to Yes$"), When("^The Super User field should be set to Yes$"), Then("^The Super User field should be set to Yes$")]
        public void TheSuperUserFieldShouldBeSetToYes() {
            Actionwords.TheSuperUserFieldShouldBeSetToYes();
        }

        [Given("^The Status field should be set to Active$"), When("^The Status field should be set to Active$"), Then("^The Status field should be set to Active$")]
        public void TheStatusFieldShouldBeSetToActive() {
            Actionwords.TheStatusFieldShouldBeSetToActive();
        }

        [Given("^The By field should be populated with SYSADMIN$"), When("^The By field should be populated with SYSADMIN$"), Then("^The By field should be populated with SYSADMIN$")]
        public void TheByFieldShouldBePopulatedWithSYSADMIN() {
            Actionwords.TheByFieldShouldBePopulatedWithSYSADMIN();
        }

        [Given("^I should see the edit icon for the user$"), When("^I should see the edit icon for the user$"), Then("^I should see the edit icon for the user$")]
        public void IShouldSeeTheEditIconForTheUser() {
            Actionwords.IShouldSeeTheEditIconForTheUser();
        }

        [Given("^I click the Search drop-down$"), When("^I click the Search drop-down$"), Then("^I click the Search drop-down$")]
        public void IClickTheSearchDropdown() {
            Actionwords.IClickTheSearchDropdown();
        }

        [Given("^I select the Search Engines entry in the Search drop-down$"), When("^I select the Search Engines entry in the Search drop-down$"), Then("^I select the Search Engines entry in the Search drop-down$")]
        public void ISelectTheSearchEnginesEntryInTheSearchDropdown() {
            Actionwords.ISelectTheSearchEnginesEntryInTheSearchDropdown();
        }

        [Given("^I click the BACK button on the browser$"), When("^I click the BACK button on the browser$"), Then("^I click the BACK button on the browser$")]
        public void IClickTheBACKButtonOnTheBrowser() {
            Actionwords.IClickTheBACKButtonOnTheBrowser();
        }

        [Given("^I click the FORWARD button on the browser$"), When("^I click the FORWARD button on the browser$"), Then("^I click the FORWARD button on the browser$")]
        public void IClickTheFORWARDButtonOnTheBrowser() {
            Actionwords.IClickTheFORWARDButtonOnTheBrowser();
        }

        [Given("^The Name field should be set to my search engine name$"), When("^The Name field should be set to my search engine name$"), Then("^The Name field should be set to my search engine name$")]
        public void TheNameFieldShouldBeSetToMySearchEngineName() {
            Actionwords.TheNameFieldShouldBeSetToMySearchEngineName();
        }

        [Given("^The Key field has my search engine key$"), When("^The Key field has my search engine key$"), Then("^The Key field has my search engine key$")]
        public void TheKeyFieldHasMySearchEngineKey() {
            Actionwords.TheKeyFieldHasMySearchEngineKey();
        }

        [Given("^The Documents field should be set to \"(.*)\"$"), When("^The Documents field should be set to \"(.*)\"$"), Then("^The Documents field should be set to \"(.*)\"$")]
        public void TheDocumentsFieldShouldBeSetToDocCount(string docCount) {
            Actionwords.TheDocumentsFieldShouldBeSetToDocCount(docCount);
        }

        [Given("^I should see the Trash Can icon for the search engine$"), When("^I should see the Trash Can icon for the search engine$"), Then("^I should see the Trash Can icon for the search engine$")]
        public void IShouldSeeTheTrashCanIconForTheSearchEngine() {
            Actionwords.IShouldSeeTheTrashCanIconForTheSearchEngine();
        }

        [Given("^I should see the Delete Selected button on the search engines page disabled$"), When("^I should see the Delete Selected button on the search engines page disabled$"), Then("^I should see the Delete Selected button on the search engines page disabled$")]
        public void IShouldSeeTheDeleteSelectedButtonOnTheSearchEnginesPageDisabled() {
            Actionwords.IShouldSeeTheDeleteSelectedButtonOnTheSearchEnginesPageDisabled();
        }

        [Given("^I click the Delete Selected button on the search engine page$"), When("^I click the Delete Selected button on the search engine page$"), Then("^I click the Delete Selected button on the search engine page$")]
        public void IClickTheDeleteSelectedButtonOnTheSearchEnginePage() {
            Actionwords.IClickTheDeleteSelectedButtonOnTheSearchEnginePage();
        }

        [Given("^I should not see the Delete toaster confirmation$"), When("^I should not see the Delete toaster confirmation$"), Then("^I should not see the Delete toaster confirmation$")]
        public void IShouldNotSeeTheDeleteToasterConfirmation() {
            Actionwords.IShouldNotSeeTheDeleteToasterConfirmation();
        }

        [Given("^I enter an email address \"(.*)\"$"), When("^I enter an email address \"(.*)\"$"), Then("^I enter an email address \"(.*)\"$")]
        public void IEnterAnEmailAddressEmail(string email) {
            Actionwords.IEnterAnEmailAddressEmail(email);
        }

        [Given("^I enter a password \"(.*)\"$"), When("^I enter a password \"(.*)\"$"), Then("^I enter a password \"(.*)\"$")]
        public void IEnterAPasswordPassword(string password) {
            Actionwords.IEnterAPasswordPassword(password);
        }

        [Given("^I login by using SysAdmin account$"), When("^I login by using SysAdmin account$"), Then("^I login by using SysAdmin account$")]
        public void ILoginByUsingSysAdminAccount() {
            Actionwords.ILoginByUsingSysAdminAccount();
        }

        [Given("^I should see the backend page$"), When("^I should see the backend page$"), Then("^I should see the backend page$")]
        public void IShouldSeeTheBackendPage() {
            Actionwords.IShouldSeeTheBackendPage();
        }

        [Given("^I should see the user full name is \"(.*)\"$"), When("^I should see the user full name is \"(.*)\"$"), Then("^I should see the user full name is \"(.*)\"$")]
        public void IShouldSeeTheUserFullNameIsFullname(string fullname) {
            Actionwords.IShouldSeeTheUserFullNameIsFullname(fullname);
        }
    }
}