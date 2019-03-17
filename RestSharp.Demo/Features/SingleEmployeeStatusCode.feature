Feature: GetSingleEmployeeStatusCode
	This page will contains information about, how to access particular employee data using rest api /employee.


@api
Scenario: Check Get Single employee status Code
Given Create Request "employee/{id}" with "GET" method
When Create URL segment for "id" with parameter "7337"
And Execute API
Then returned status code will be "200"