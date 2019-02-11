@LOGIN
Feature: Login


  Background:
    Given I go to the VSMC site
    Then I should see the VSMC login page

  @AUTO_READY @LOGIN
  Scenario: Successful default login and logout (uid:5b840636-7944-4afa-8175-91d2b049f56d)
    When I enter an email address "sysadmin@visioninternet.com"
    And I enter a password "p_sysadmin_password"
    Then The Log in button should be enabled
    When I click the Log in button
    Then I should see the Search Engines page
    Then I log out of the system
    Then I should see the VSMC login page

  @AUTO_READY @LOGIN
  Scenario: Unsuccessful system administrator login (uid:f0d8da9d-7069-4218-ac00-ff5dd72a6eaf)
    And I unsuccessfully login as a SYSADMIN

  @LOGIN @AUTO_READY
  Scenario: Successful user login and logout (uid:a682a789-3be2-4b6a-a051-e5ba383e49fa)
    When I enter an email address of SUPER _USER
    And I enter a password of SUPER_USER_PASSWORD
    Then The Log in button should be enabled
    When I click the Log in button
    And I should see the Search Engines page
    When I log out of the system
    Then I should see the VSMC login page

  @LOGIN @AUTO_READY
  Scenario: Required fields for login (uid:68fbf401-d6eb-44f8-9dcd-6f3d4972e868)
    When I press tab on the email address field
    Then I should see the Email is required message
    And I should see the Password is required message
    And The Log in button should be disabled

  @LOGIN @AUTO_READY
  Scenario: Login attempts are not restricted (uid:78590e2a-a8e8-4cfd-9564-4112fc501f09)
    Since most systems have a login attempts limited to 3 before you are locked out or 5 in the CMS case, attempt to login five unsuccessful time and then a sixth successful time.
    Then I unsuccessfully login as a SYSADMIN
    Then I unsuccessfully login as a SYSADMIN
    Then I unsuccessfully login as a SYSADMIN
    Then I unsuccessfully login as a SYSADMIN
    Then I unsuccessfully login as a SYSADMIN
    Then I successfully login as a SYSADMIN

  @LOGIN @AUTO_READY
  Scenario: Restrictions on email and password fields (uid:d40bf40f-8c25-4225-9fba-f173232b7e01)
    When I enter an email address of BAD_EMAIL
    Then I should see the message "Email must be a valid email address"
    When I clear the email address field
    And I enter an email address of a SYSTEM_ADMIN
    When I enter a password of SHORT_PASSWORD
    Then I should see the message "Password must be at least 8 characters"
    And The Log in button should be disabled

  Scenario: Successful login by SysAdmin account (uid:a7003aeb-1a31-416a-bbc5-165fd5e82eff)
    Given I login by using SysAdmin account
    Then I should see the backend page
    And I should see the user full name is "System, Admin"
