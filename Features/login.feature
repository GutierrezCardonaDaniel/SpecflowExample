Feature: login
  I want to login into the application as an admin user

Scenario Outline: login as admin using chrome browser
    Given I am in the landing page using <webBrowser>
    When I login into the application using admin credentials
    Then I should get to the admin dashboard page

Examples:
    | webBrowser |
    | chrome     |
    | firefox    |