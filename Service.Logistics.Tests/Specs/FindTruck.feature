Feature: FindTruck API

Scenario: Finding trucks with a valid request
	When a user sends a POST request to "/api/Location/FindTruck" with the following request body:
		"""
		{
		  "latitude": 37.794331003246846,
		  "longitude": -122.39581105302317,
		  "resultsCount": 100,
		  "preferredFood": "Fried Chicken"
		 }
		"""
	Then the response should contain a collection of TruckResponseDto
	And each TruckResponseDto should have the required properties
