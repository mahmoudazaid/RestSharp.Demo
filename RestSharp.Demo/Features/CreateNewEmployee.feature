Feature: CreateNewEmployee
This page will contains information about, how to create employee data using rest /employee.

Scenario: Create a new employee
Given Create Request "create" with "POST" method
When I create a request body with the following values
| name		 |salary| age |  
|TestEmployee| 5000 |25   |
And Add the serialized body to the API request
And Execute API
Then returned status code will be "200"