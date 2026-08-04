# Mini SRS – Prototype 1: Console Calculator

## 1. Objective
Develop a C# console application that performs basic arithmetic operations between two integer numbers entered by the user.

## 2. Functional Requirements (FR)
* **FR1.** The system shall prompt the user to enter a first number.
* **FR2.** The system shall validate that the entered value is an integer.
* **FR3.** If the entered value is invalid, the system shall continuously prompt the user until a valid integer is provided.
* **FR4.** The system shall prompt the user to enter a mathematical operator (`+`, `-`, `*`, or `/`).
* **FR5.** The system shall validate that the entered operator is one of the allowed options.
* **FR6.** If the entered operator is invalid, the system shall prompt the user to re-enter a valid operator.
* **FR7.** The system shall prompt the user to enter a second number.
* **FR8.** The system shall validate that the second entered value is an integer.
* **FR9.** If the entered value is invalid, the system shall continuously prompt the user until a valid integer is provided.
* **FR10.** The system shall calculate the result of the selected operation.
* **FR11.** The system shall display the operation result in the console.

## 3. Non-Functional Requirements (NFR)
* **NFR1.** The application shall be a console application.
* **NFR2.** Development shall be carried out using C# and .NET.
* **NFR3.** The program shall work exclusively with integer numbers (`int`).
* **NFR4.** User interaction shall be handled through console text input and output.
* **NFR5.** The program shall not use external libraries.

## 4. Test Cases

| ID | Description | Expected Result |
| :--- | :--- | :--- |
| **TC1** | `2 + 3` | Result: `5` |
| **TC2** | `10 - 7` | Result: `3` |
| **TC3** | `6 * 8` | Result: `48` |
| **TC4** | `20 / 5` | Result: `4` |
| **TC5** | Enter `"abc"` as a number | The system prompts for a number again. |
| **TC6** | Enter `"%"` as an operator | The system prompts for a valid operator again. |
| **TC7** | Enter negative numbers | The system successfully performs the operation. |

## 5. Potential Improvements (Backlog)

### Functional
* Allow operations with decimal numbers (`double` or `decimal`).
* Handle division by zero gracefully without crashing the application. **This should be the first upgrade.**
* Support executing multiple operations without restarting the application.
* Add an option to exit the program in a controlled manner.

### Technical
* Refactor the code using dedicated methods (`GetNumber()`, `GetOperator()`, `Calculate()`).
* Eliminate duplicate code in input validation.
* Improve code organization and readability.