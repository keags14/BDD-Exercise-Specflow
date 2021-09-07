Feature: CalculatorFeatureFile
	As a trainee, I would like to have a calculator so that I can do simple calculations

@operations
Scenario: Addition
	Given I have a calculator
	And I enter 5 and 2 into the calculator
	When I press add
	Then the result should be 7

@operations
Scenario: Subtraction
	Given I have a calculator
	And I enter <input1> and <input2> into the calculator
	When I press subtract
	Then the result should be <result>
Examples: 
| input1 | input2 | result |
| 1      | 1      | 0      |
| 0      | 1      | -1     |
| 1000   | 5      | 995    |

@operations
Scenario: Multiply
	Given I have a calculator
	And I enter <input1> and <input2> into the calculator
	When I press multiply
	Then the result should be <result>
Examples: 
| input1 | input2 | result |
| 1      | 1      | 1      |
| 2      | 3      | 6      |
| 9      | 9      | 81     |
| 5      | -17    | -85    |

@operations
Scenario: Divide
	Given I have a calculator
	And I enter <input1> and <input2> into the calculator
	When I press divide
	Then the result should be <result>
Examples: 
| input1 | input2 | result |
| 1      | 1      | 1      |
| 8      | 2      | 4      |

@operations
Scenario: Divide By Zero
	Given I have a calculator
	And I enter <input1> and 0 into the calculator
	Then a DivideByZero Exception should be thrown with the exception message "Cannot Divide By Zero" when I press divide
Examples: 
| input1 |
| 1      |
| 6      |

@operation
Scenario: SumOfNumberDivisibleBy2
	Given I have a calculator
	And I enter the numbers below to a list
	| nums |
	| 1    |
	| 2    |
	| 3    |
	| 4    |
	| 5    |
	When I iterate through the list to add all the even numbers
	Then the result should be 6