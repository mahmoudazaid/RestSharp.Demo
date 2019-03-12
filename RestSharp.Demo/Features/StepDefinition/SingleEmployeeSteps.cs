using FluentAssertions;
using RestSharp.Demo.Model;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace RestSharp.Demo.Features.StepDefinition
{
    [Binding]
    public sealed class SingleEmployeeSteps
    {        

        [When(@"Deserialize the employee api content")]
        public void WhenDeserializeTheEmployeeApiContent()
        {
            var deserializer = new JsonDeserializer();

            Employee employee_info = deserializer.Deserialize<Employee>(SharedSteps.apiResult);
        }


        [Then(@"I get back the following employee_info")]
        public void ThenReturnedEmployeeShouldBe(Table table)
        {
            var employee = table.CreateSet<Employee>();
            //employee.Should().Be(SharedSteps.employee_info);
        }        
    }
}
