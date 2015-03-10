# uWaterloo API - C# Client
---

##About
A client library created in C# that allows users to quickly jump in and start using uWaterloo's OpenData API. 

This will hopefully help create a lower barrier of entry to the API, as users will no longer have to worry about dynamics, WebClients, JSON, etc. 

##Usage

Include 

```C#
using UWaterlooApi.  

...

UWaterlooApi myUw = new UWaterlooApi("YOUR-API-KEY");

var foodServicesWeeklyMenu = uwaterlooApiClient.FoodServices.WeeklyFoodMenu(2013, 12);

```

##Where do I get my API key?
https://api.uwaterloo.ca/

##How do I call the correct endpoint?
Simply create a `UWaterlooApi` object and call the methods corresponding to the endpoint paths outlined in https://github.com/uWaterloo/api-documentation

## Dependencies 
* **Newtonsoft.Json**

## Acknowledgments
* **University of Waterloo**

## Licensing
The MIT License (MIT), see "LICENSE.txt" for more details.
