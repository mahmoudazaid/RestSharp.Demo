Feature: GetSingleEmployeeApi
	This page will contains information about, how to access particular employee data using rest api /employee.


@api
Scenario: Check Get Single employee status
Given Create Request "employee/{id}" with method "GET"
When Create URL segment for "id" with parameter "4845"
And Execute API
Then returned status code will be "200"