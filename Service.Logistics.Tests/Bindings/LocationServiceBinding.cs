﻿using FluentAssertions;
using Newtonsoft.Json;
using Service.Logistics.Models;
using System.Text;
using TechTalk.SpecFlow;

namespace Service.Logistics.Tests.Bindings
{
    [Binding]
    public class LocationServiceBinding
    {
        private readonly HttpClient client = new HttpClient();
        private HttpResponseMessage response;

        [Given("the API is running")]
        public void GivenTheApiIsRunning()
        {
            // Assume the API is running; you may add further setup steps if needed
        }

        [When(@"a user sends a POST request to ""(.*)"" with the following request body:")]
        public async Task WhenAUserSendsAPostRequestToWithTheFollowingRequestBody(string endpoint, string requestBody)
        {
            var requestContent = new StringContent(requestBody, Encoding.UTF8, "application/json");
            response = await client.PostAsync($"http://localhost:5070/api/{endpoint}", requestContent);
        }

        [Then(@"the response should contain a collection of TruckResponseDto")]
        public async Task ThenTheResponseShouldContainACollectionOfTruckResponseDto()
        {
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var truckResponseList = JsonConvert.DeserializeObject<List<TruckResponseDto>>(responseContent);

            truckResponseList.Should().NotBeNull();
            truckResponseList.Should().BeOfType<List<TruckResponseDto>>();
        }

        [Then(@"each TruckResponseDto should have the required properties")]
        public async Task ThenEachTruckResponseDtoShouldHaveTheRequiredProperties()
        {
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var truckResponseList = JsonConvert.DeserializeObject<List<TruckResponseDto>>(responseContent);

            foreach (var truckResponse in truckResponseList)
            {
                truckResponse.Should().NotBeNull();
                truckResponse.FoodItems.Should().NotBeNull();
                truckResponse.Name.Should().NotBeNull();
            }
        }
    }
}
