Feature: multiply
  new multiplication feature for the calculator

  Scenario: multiply two numbers
    Given the first number is 5
    And the second number is 3
    When the calculator multiplies both numbers
    Then the resulting value should be 15