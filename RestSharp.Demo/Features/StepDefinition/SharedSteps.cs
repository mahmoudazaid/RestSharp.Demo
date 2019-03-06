using FluentAssertions;
using RestSharp.Demo.Utilities;
using TechTalk.SpecFlow;

namespace RestSharp.Demo.Features.StepDefinition
{
   
    [Binding]
    public sealed class SharedSteps
    {
        public static RestRequest request;
        public IRestResponse apiResult;
        [Given(@"Create Request ""(.*)"" with method ""(.*)""")]
        public void GivenCreateRequestWithMethod(string _request , Method _method)
        {
            request = new RestRequest(_request,_method);
            request.RequestFormat = DataFormat.Json;
        }


        [When(@"Create URL segment for ""(.*)"" with parameter (.*)")]
        public void ThenCreateURLSegmentForWithParameter(string _segment, string _parameter)
        {
            request.AddUrlSegment(_segment, _parameter);
        }

        [When(@"Execute API")]
        public void ThenExecuteAPI()
        {
            apiResult = Client.api.Execute(request);            
        }

        [Then(@"returned status code will be ""(.*)""")]
        public void ThenReturnedStatusCodeWillBe(int _status)
        {
            var code = apiResult.StatusCode;
            code.Should().Be(_status);            
        }



    }

}
