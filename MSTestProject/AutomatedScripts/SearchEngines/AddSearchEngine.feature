Feature: Add Search Engine


  Background:
    Given I go to the VSMC site
    And I should see the VSMC login page
    And I successfully login as a SYSADMIN

  @SEARCH_ENGINE @AUTO_READY
  Scenario: Create Search Engine, search, and verify data on main search engine page (uid:88ebcfef-173f-48f4-a699-416458491a63)
    And I count the number of search engines on the page
    And I should see Display 1-count of total on the page
    When I click the Add Search Engine button
    Then I should see the Add Search Engine details screen
    And I enter a random automated search engine name
    And I verify that the Key Prefix is set to STANDARD_KEY
    And I enter a description of "Automated created search engine"
    And I click the Save button on the search engine details page
    Then I should see the Add Successful toaster confirmation
    Then I should see the Search Engines page
    When I search for my search engine by Name
    Then I should see my search engine in the list of search engines
    And The Name field should be set to my search engine name
    And The Documents field should be set to "0"
    And The Key field has my search engine key
    And I should see a Last Updated timestamp of current time
    And I should see a By field populated with SYSADMIN
    And I should see the Edit icon for the search engine
    And I should see the Trash Can icon for the search engine
    And I should see the search result of "Displaying 1 - 1 of 1"
    And I clear the search engine box
    And I should see Display 1-count of total on the page
