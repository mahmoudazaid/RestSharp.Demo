Feature: GetSingleEmployeeApi
	This page will contains information about, how to access particular employee data using rest api /employee.


@api
Scenario: Check Get Single employee status
Given Create Request "employee/{id}" with method "GET"
When Create URL segment for "id" with parameter "7337"
And Execute API
#Then returned status code will be "200"
#When Deserialize the employee api content
Then I get back the following employee_info
#| key              | value            |
#| id               | 7337             |
#| employee_name    | Chantalle Boodle |
#| employee_salary  | 97557            |
#| employee_age     | 17               |

| id   | employee_name    | employee_salary  | employee_age | profile_image |
| 7337 | Chantalle Boodle | 97557            | 17           |               |

