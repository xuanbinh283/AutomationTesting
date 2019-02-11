namespace Example {

    public class Actionwords {

        public void IClickTheLogInButton() {

        }

        public void IClickTheSearchEnginesOption() {

        }

        public void IGoToTheVSMCSite() {

        }

        public void IShouldSeeTwoDisabledDeleteSelectedButton() {

        }

        public void IShouldSeeTwoEnabledAddSearchEngineButton() {

        }

        public void IShouldSeeASearchBox() {

        }

        public void IShouldSeeSearchEngineLabelTitlesOfNameKeyDocumentsLastUpdatedByEditAndDeleteHeadings() {

        }

        public void IShouldSeeMySearchEngine() {

        }

        public void IShouldSeeADefaultDisplayPerPageOf20() {

        }

        public void ICountTheNumberOfSearchEnginesOnThePage() {

        }

        public void IVerifyALabelOfDisplayingItems1CountOfTotalIsDisplayedOnThePage(string count, string total) {

        }

        public void IVerifyPagePageNumberIsSelected(string pageNumber) {

        }

        public void ISearchForMySearchEngineByName() {

        }

        public void IVerifyThatOnlySearchEnginesThatMatchTheSearchTextByNameAppear() {

        }

        public void ISearchForMySearchEngineByKey() {

        }

        public void IShouldNotSeeMySearchEngine() {

        }

        public void ISelectMySearchEngine() {

        }

        public void IVerifyMySearchEngineIsChecked() {

        }

        public void IUnselectMySearchEngine() {

        }

        public void IVerifyMySearchEngineIsUnchecked() {

        }

        public void ISelectTheMainCheckboxForSearchEngines() {

        }

        public void IVerifyThatAllSearchEnginesAreSelected() {

        }

        public void IClickOnTheNameColumnHeader() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedAscendinglyByName() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedDescendinglyByName() {

        }

        public void IClickOnTheKeyColumnHeader() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedAscendinglyByKey() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedDescendinglyByKey() {

        }

        public void IClickOnTheDocumentsColumnHeader() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedAscendinglyByDocuments() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedDescendinglyByDocuments() {

        }

        public void IClickOnTheLastUpdatedColumnHeader() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedAscendinglyByLastUpdated() {

        }

        public void IVerifyThatTheSearchEnginesAreSortedDescendinglyByLastUpdated() {

        }

        public void IClickOnTheByColumnHeader() {

        }

        public void IShouldNotSeeTheCaretSymbolNextToTheByColumnHeader() {

        }

        public void IRefreshThePage() {

        }

        public void ILogOutOfTheSystem() {

        }

        public void IShouldSeeTheVSMCLoginPage() {

        }

        public void IShouldSeeTheToasterConfirmationThatTheLoginHasFailed() {

        }

        public void IShouldSeeTheSearchEnginesPage() {

        }

        public void IShouldNotSeeTheSearchEnginesPage() {

        }

        public void IEnterAnEmailAddressOfASYSTEMADMIN() {

        }

        public void IPressTabOnTheEmailAddressField() {

        }

        public void IShouldSeeTheEmailIsRequiredMessage() {

        }

        public void IShouldSeeThePasswordIsRequiredMessage() {

        }

        public void TheLogInButtonShouldBeDisabled() {

        }

        public void TheLogInButtonShouldBeEnabled() {

        }

        public void IEnterAPasswordOfSYSTEMADMINPASSWORD() {

        }

        public void IEnterAPasswordOfBADPASSWORD() {

        }

        public void IEnterAnEmailAddressOfSUPERUSER() {

        }

        public void IEnterAPasswordOfSUPERUSERPASSWORD() {

        }

        public void IClearTheEmailAddressField() {

        }

        public void IClearThePasswordField() {

        }

        public void IUnsuccessfullyLoginAsASYSADMIN() {
            IClearTheEmailAddressField();
            IEnterAnEmailAddressOfASYSTEMADMIN();
            IClearThePasswordField();
            IEnterAPasswordOfBADPASSWORD();
            IClickTheLogInButton();
            IShouldSeeTheToasterConfirmationThatTheLoginHasFailed();
        }

        public void ISuccessfullyLoginAsASYSADMIN() {
            IClearTheEmailAddressField();
            IEnterAnEmailAddressOfASYSTEMADMIN();
            IClearThePasswordField();
            IEnterAPasswordOfSYSTEMADMINPASSWORD();
            IClickTheLogInButton();
            IShouldSeeTheSearchEnginesPage();
        }

        public void IEnterAnEmailAddressOfBADEMAIL() {

        }

        public void IShouldSeeTheMessageTheScreenText(string theScreenText) {

        }

        public void IEnterAPasswordOfSHORTPASSWORD() {

        }

        public void IClickTheAddSearchEngineButton() {

        }

        public void IShouldSeeTheAddSearchEngineDetailsScreen() {

        }

        public void IEnterARandomAutomatedSearchEngineName() {

        }

        public void IVerifyThatTheKeyPrefixIsSetToSTANDARDKEY() {

        }

        public void IEnterADescriptionOfMyDescription(string myDescription) {

        }

        public void IClickTheSaveButtonOnTheSearchEngineDetailsPage() {

        }

        public void IShouldSeeTheAddSuccessfulToasterConfirmation() {

        }

        public void IShouldSeeMySearchEngineInTheListOfSearchEngines() {
            // Then I should see my search engine name
            IShouldSeeMySearchEngineName();
            // And I should see the key prefixed by STANDARD_KEY
            IShouldSeeTheKeyPrefixedBySTANDARDKEY();
            // And The key should contain "20" characters
            TheKeyShouldContainCharCountCharacters("20");
            // And I should see a document count of 0
            IShouldSeeADocumentCountOf0();
            // And I should see a Last Updated timestamp of current time
            IShouldSeeALastUpdatedTimestampOfCurrentTime();
            // And I should see a By field populated with SYSADMIN
            IShouldSeeAByFieldPopulatedWithSYSADMIN();
            // And I should see the Edit icon for the search engine
            IShouldSeeTheEditIconForTheSearchEngine();
            // And I should see the Delete icon for the search engine
            IShouldSeeTheDeleteIconForTheSearchEngine();
        }

        public void IShouldSeeMySearchEngineName() {

        }

        public void IShouldSeeTheKeyPrefixedBySTANDARDKEY() {

        }

        public void IShouldSeeADocumentCountOf0() {

        }

        public void IShouldSeeALastUpdatedTimestampOfCurrentTime() {

        }

        public void IShouldSeeAByFieldPopulatedWithSYSADMIN() {

        }

        public void IShouldSeeTheEditIconForTheSearchEngine() {

        }

        public void IShouldSeeTheDeleteIconForTheSearchEngine() {

        }

        public void TheKeyShouldContainCharCountCharacters(string charCount) {

        }

        public void IShouldSeeTheSearchResultOfP1(string p1) {

        }

        public void IClearTheSearchEngineBox() {

        }

        public void IShouldSeeDisplay1countOfTotalOnThePage() {

        }

        public void IClickTheTrashCanAssociatedWithMySearchEngine() {

        }

        public void IShouldSeeTheDeleteConfirmationModal() {

        }

        public void IClickYesOnTheDeleteConfirmationModal() {

        }

        public void IShouldSeeDeleteToasterConfirmation() {

        }

        public void IShouldNotSeeMySearchEngineInTheListOfSearchEngines() {

        }

        public void IClickNoOnTheDeleteConfirmationModal() {

        }

        public void IAddMySearchEngineIfItDoesNotAlreadyExist() {

        }

        public void IClickTheAdminDropdown() {

        }

        public void ISelectTheUsersEntryInTheAdminDropdown() {

        }

        public void IShouldSeeTheUsersMainPage() {

        }

        public void IClickTheAddUserButton() {

        }

        public void IEnterMyUsersFirstName() {

        }

        public void IEnterMyUsersLastName() {

        }

        public void IEnterMyUsersEmail() {

        }

        public void IEnterMyUsersPasswordInThePasswordField() {

        }

        public void IEnterMyUsersPasswordInTheConfirmPasswordField() {

        }

        public void IShouldSeeTheActiveCheckboxIsAlreadyChecked() {

        }

        public void ICheckTheSuperUserCheckbox() {

        }

        public void IClickTheAddButtonOnTheAddUserDetailsPage() {

        }

        public void ISearchForMyUserByTheirEmailAddress() {

        }

        public void IShouldSeeMyUserInTheListOfUsers() {

        }

        public void TheFullNameFieldShouldHaveMyUserLastnameFirstname() {

        }

        public void TheEmailFieldShouldBeMyUsersEmail() {

        }

        public void TheSuperUserFieldShouldBeSetToYes() {

        }

        public void TheStatusFieldShouldBeSetToActive() {

        }

        public void TheByFieldShouldBePopulatedWithSYSADMIN() {

        }

        public void IShouldSeeTheEditIconForTheUser() {

        }

        public void IClickTheSearchDropdown() {

        }

        public void ISelectTheSearchEnginesEntryInTheSearchDropdown() {

        }

        public void IClickTheBACKButtonOnTheBrowser() {

        }

        public void IClickTheFORWARDButtonOnTheBrowser() {

        }

        public void TheNameFieldShouldBeSetToMySearchEngineName() {

        }

        public void TheKeyFieldHasMySearchEngineKey() {

        }

        public void TheDocumentsFieldShouldBeSetToDocCount(string docCount) {

        }

        public void IShouldSeeTheTrashCanIconForTheSearchEngine() {

        }

        public void IShouldSeeTheDeleteSelectedButtonOnTheSearchEnginesPageDisabled() {

        }

        public void IClickTheDeleteSelectedButtonOnTheSearchEnginePage() {

        }

        public void IShouldNotSeeTheDeleteToasterConfirmation() {

        }

        public void IEnterAnEmailAddressEmail(string email) {

        }

        public void IEnterAPasswordPassword(string password) {

        }

        public void ILoginByUsingSysAdminAccount() {

        }

        public void IShouldSeeTheBackendPage() {

        }

        public void IShouldSeeTheUserFullNameIsFullname(string fullname) {

        }

        public void IEnterAnEmailAddressOfAPSysadminEmail(string pSysadminEmail) {

        }
    }
}