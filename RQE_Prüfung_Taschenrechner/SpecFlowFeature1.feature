Feature: Trigonometrischer Taschenrechner
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the trigonometric results of a number

@mytag
Scenario: Calculate Sinus
	Given a <number>
	When i want to know the Sinus
	Then the result should be <result>

Examples: 
| number  | result |
| PI	  | 0      |

Scenario Outline: Calculate Cosinus
	Given a <number>
	When i want to know the Cosinus
	Then the result should be <result>

Examples: 
| number  | result |
| PI	  | -1     |


Scenario Outline: Calculate Tangens
	Given a <number>
	When i want to know the Tangens
	Then the result should be <result>

Examples: 
| number  | result |
| PI	  | 0      |