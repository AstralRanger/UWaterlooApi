# uWaterloo API - C# Client
---

###About
A library created in C# that allows users to quickly and easily use uWaterloo's API. 

###Where do I get my API key?
https://api.uwaterloo.ca/

###How do I call the correct endpoint?
Simply create a `UWaterlooApi` object and call the methods corresponding to the endpoint paths outlined in https://github.com/uWaterloo/api-documentation

####Examples

```C#

UWaterlooApi myUw = new UWaterlooApi("YOUR-API-KEY");
myUw
test.foodservices.menu(); 



```
