# uWaterloo API - C# Client
---

##About
A client library created in C# that allows users to quickly jump in and start using uWaterloo's OpenData API. 

This will hopefully help create a lower barrier of entry to the API, as users will no longer have to worry about dynamics, WebClients, JSON, etc.

##Where do I get my API key?
https://api.uwaterloo.ca/

##How do I call the correct endpoint?
Simply create a `UWaterlooApi` object and call the methods corresponding to the endpoint paths outlined in https://github.com/uWaterloo/api-documentation

##Usage

```C#

UWaterlooApi myUw = new UWaterlooApi("YOUR-API-KEY");

var foodServicesWeeklyMenu = uwaterlooApiClient.FoodServices.WeeklyFoodMenu(2013, 12);

```

## Dependencies 
* **Newtonsoft.Json**

## Acknowledgments
* **University of Waterloo**

## Licensing
The MIT License (MIT)

Copyright (c) 2015, Robinson Mann

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
