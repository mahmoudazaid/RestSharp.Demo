Feature: GetSingleEmployeeContent
	This page will contains information about, how to access particular employee data using rest api /employee.


@api
Scenario: Check Get Single employee Content
Given Create Request "employee/{id}" with "GET" method
When Create URL segment for "id" with parameter "8126"
And Execute API
And Deserialize the employee api content
Then The employee should have the following values
|Key			  |Value		 |
| id              | 8126         |
| employee_name   | Joey Smith	 |
| employee_salary | 49258        |
| employee_age    | 64           |
| profile_image	  |				 |