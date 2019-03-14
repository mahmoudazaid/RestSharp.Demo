using FluentAssertions;
using RestSharp.Demo.Model;
using RestSharp.Serialization.Json;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace RestSharp.Demo.Features.StepDefinition
{
    [Binding]
    public sealed class SingleEmployeeSteps
    {
        private static Employee employee_info;
        private JsonDeserializer deserializer = new JsonDeserializer();


        [When(@"Deserialize the employee api content")]
        public void WhenDeserializeTheEmployeeApiContent()
        {
            employee_info = deserializer.Deserialize<Employee>(SharedSteps.apiResult);
            var type = employee_info.GetType();
        }

        [Then(@"The employee should have the following values")]
        public void ThenTheEmployeeShouldHaveTheFollowingValues(Table table)
        {
            var employee = table.CreateInstance<Employee>();
            employee_info.Should().BeEquivalentTo(employee);
        }
    }
}
