UWaterloo API - C# Client
-----

#About

Calls API endpoints and converts the returned data into static typed objects.

Lower barrier of entry to the API as you can quickly use it; regardless of your knowledge about WebClients, Deserilzation, etc.

#Installation

Distributed via Nuget. More information to follow

#Usage

API calls are made by calling members on the UWaterlooApi class.
e.g. `uWaterlooApi.FoodServices.WeeklyFoodMenu(2013, 12)`

All API calls return uWaterlooApi.ApiRequest &lt;T&gt; where T is the static typed object that deals with the particular API call.

ApiRequest&lt;T&gt; is a wrapper containing 2 fields: meta, and data.
- `meta` contains information about the api called (that was returned by the server).
- `data` of type T and contains the data section returend from the API call.


#Examples

```C#
UWaterlooApi uWaterlooApiClient = new UWaterlooApi("YOUR-API-KEY");
```

To get the Weekly Food menu for the 12th week of 2013

```C#
var foodServicesWeeklyMenu = uwaterlooApiClient.FoodServices.WeeklyFoodMenu(2013, 12);
```

#Where do I get my API key?
https://api.uwaterloo.ca/

#Contributing
Any contributes are welcome, however help is most needed with documentation, and testing.

If you notice any bugs feel free to either submit an issue, or if you have the technical knowhow to fix it yourself, feel free to fork, fix, and submit a pull request.

#Implementation

Info about each file

#Where do I get my API key?
https://api.uwaterloo.ca/

#Dependencies
* **Newtonsoft.Json**

#Acknowledgments
* **University of Waterloo**

#Licensing
The MIT License (MIT), see "LICENSE.txt" for more details.
