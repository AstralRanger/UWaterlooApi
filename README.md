# uWaterloo API - C# Client
---

###About
A client library created in C# that allows users to quickly jump in and start using uWaterloo's OpenData API. 

###Where do I get my API key?
https://api.uwaterloo.ca/

###How do I call the correct endpoint?
Simply create a `UWaterlooApi` object and call the methods corresponding to the endpoint paths outlined in https://github.com/uWaterloo/api-documentation

####Examples

```C#
UWaterlooApi myUw = new UWaterlooApi("YOUR-API-KEY");
test.foodservices.menu(); 
```
###Status
* **Food Services** - Classes completed. Need JsonProperty Tags
* **Course** - Classes completed. Need JsonProperty Tags
* **Events** - Not Started
* **News** - Not Started
* **Weather** - Completed
* **Terms** - Not Started
* **Resources** - Started
* **Definitions and Codes** - Not Started
* **Building** - Not Started
* **API** - Not Started
* **Server** - Completed


### Acknowledgments
**University of Waterloo**

**Jonathan Keith** -- Creator of http://json2csharp.com/
