# UWaterloo API C# Client
---

##About
A client library created in C# that allows users to quickly jump in and start using uWaterloo's OpenData API. 

This will hopefully help create a lower barrier of entry to the API, as users will no longer have to worry about dynamics, WebClients, JSON, etc. 

##Usage

API calls are made by calling endpoints on the UWaterloApi class. e.g. `uWaterlooApi.FoodServices.WeeklyFoodMenu(2013, 12)`

All API calls return type uWaterlooApi.ApiRequest &lt;T&gt; where T is the data class revelent to the API call.

ApiRequest&lt;T&gt; is a wrapper containing 2 fields: meta, and data.
- meta cotnains information about the API call.
- data is type T and contains the relevent data returned from the API call.


####Examples

```C#
using uWaterlooApi;
UWaterlooApi uWaterlooApiClient = new UWaterlooApi("YOUR-API-KEY");
```


To get the Weekly Food menu for the 12th week of 2013 
```C#
var foodServicesWeeklyMenu = uwaterlooApiClient.FoodServices.WeeklyFoodMenu(2013, 12);
```

##Where do I get my API key?
https://api.uwaterloo.ca/

## Dependencies 
* **Newtonsoft.Json**

## Acknowledgments
* **University of Waterloo**

## Licensing
The MIT License (MIT), see "LICENSE.txt" for more details.
