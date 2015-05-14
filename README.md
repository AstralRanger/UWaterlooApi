UWaterloo API - C# Client
-----

##About

Calls University of Waterloo API endpoints and converts the returned data into static typed objects.

For the API's documentation visit [here](https://github.com/uWaterloo/api-documentation)

The motivation for this project was to create a lower barrier of entry to the API, as users no longer have to worry about WebClients, Deserilzation, etc.

##Installation

Distributed via NuGet. You can find the package page [here](https://www.nuget.org/packages/UWaterlooApi/)

To install UWaterloo API Client, run the following command in the Package Manager Console

```
PM> Install-Package UWaterlooApi
```

##Usage

API calls are made by calling members on a UWaterlooApi object.
e.g. `uWaterlooApi.FoodServices.WeeklyFoodMenu(2013, 12)`

All API call methods return type uWaterlooApi.ApiRequest&lt;T&gt; where T is the static typed object that deals with the particular API call.

ApiRequest&lt;T&gt; is a wrapper containing 2 fields: meta, and data.
- `meta` contains meta information about the API call. This information is given from the server on every API call.
- `data` contains the data section returend from the API call. This will be of type T. 


##Examples

```C#
UWaterlooApi uWaterlooApiClient = new UWaterlooApi("YOUR-API-KEY");
```

To get the Weekly Food menu for the 12th week of 2013

```C#
var foodServicesWeeklyMenu = uwaterlooApiClient.FoodServices.WeeklyFoodMenu(2013, 12);
```

##Contributing
Any contributes are welcome, however help is most needed with documentation, and testing.

If you notice any bugs feel free to either submit an issue, or if you have the technical knowhow to fix it yourself, feel free to fork, fix, and submit a pull request.

##Where do I get my API key?
https://api.uwaterloo.ca/

##Dependencies
* **Newtonsoft.Json**

##Acknowledgments
* **University of Waterloo**

##Licensing
The MIT License (MIT), see "LICENSE.txt" for more details.
