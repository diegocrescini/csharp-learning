# Mini SRS – Prototype 2: Currency Converter

## 1. Objective
Develop a C# console application that converts an amount from a source currency to a target currency using the United States Dollar (USD) as the reference currency.

## 2. Functional Requirements (FR)
* **FR1.** The system shall store a dataset containing the available currencies and their exchange rates relative to the United States Dollar (USD).
* **FR2.** The system shall prompt the user to select the source currency.
* **FR3.** The system shall validate that the selected source currency exists in the dataset.
* **FR4.** The system shall prompt the user to enter the amount to be converted.
* **FR5.** The system shall validate that the entered amount is a valid numeric value.
* **FR6.** The system shall prompt the user to select the target currency.
* **FR7.** The system shall validate that the selected target currency exists in the dataset.
* **FR8.** The system shall calculate the equivalent value of the entered amount in US Dollars.
* **FR9.** The system shall calculate the equivalent amount in the target currency.
* **FR10.** The system shall display the conversion result in the console.

## 3. Business Rules (BR)
* **BR1.** The United States Dollar (USD) shall serve as the base currency for all conversions.
* **BR2.** The system shall operate exclusively with five predefined currencies for this prototype.
* **BR3.** Exchange rates shall be fixed hardcoded values defined in the source code.
* **BR4.** Exchange rates shall not be retrieved from the Internet or external files.

## 4. Non-Functional Requirements (NFR)
* **NFR1.** The application shall be a console application.
* **NFR2.** Development shall be carried out using C# and .NET.
* **NFR3.** User interaction shall be handled through the console.
* **NFR4.** The program shall not use external databases or third-party services.
* **NFR5.** Financial calculations shall use standard high-precision numeric types (`decimal`)."

## 5. Test Cases
*(To be completed once the prototype implementation is finished.)*

## 6. Potential Improvements (Backlog)
* Read exchange rates from a file.
* Fetch real-time exchange rates from an external API.
* Allow users to add new currencies dynamically.
* Display all available exchange rates.
* Maintain and show a conversion history log.
* Support executing multiple conversions without restarting the application.