using UWaterlooApi.FoodServices;
using UWaterlooAPI.Courses;
using UWaterlooAPI.Server;
using UWaterlooAPI.Weather;

namespace UWaterlooApi
{
	/// <summary>
	/// UWaterlooAPI Class
	/// </summary>
    public class UWaterlooApi
    {

		public readonly FoodServicesApi Foodservices;
		public readonly CoursesApi Courses;
		public readonly ServerApi Server;
		public readonly WeatherApi Weather;

		/// <summary>
		/// Default constructor 
		/// </summary>
		/// <param name="apiKey">UWaterloo API Key</param>
		public UWaterlooApi(string apiKey) {
			Foodservices = new FoodServicesApi(apiKey);
			Courses = new CoursesApi(apiKey);
			Server = new ServerApi(apiKey);
			Weather = new WeatherApi(apiKey);
		}
	}
}
