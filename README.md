# SpecFlow calculator code kata
A simple solution to the SpecFlow default template 'Calculator' feature, using NUnit and SpecFlow

#### Feature

Feature: Addition<br />
 In order to avoid silly mistakes<br />
 As a math idiot<br />
 I want to be told the sum of two numbers<br />
<br />
Scenario: Add two numbers<br />
 Given I have entered 50 into the calculator<br />
 And I have entered 70 into the calculator<br />
 When I press add<br />
 Then the result should be 120 on the screen<br />
