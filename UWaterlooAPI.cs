using UWaterlooApi.FoodServices;

namespace UWaterlooApi
{
	/// <summary>
	/// UWaterlooAPI Class
	/// </summary>
    public class UWaterlooApi
    {
		// Your API key
		readonly string _apiKey;

		public readonly FoodServicesApiService Foodservices;
		
		/// <summary>
		/// Default constructor 
		/// </summary>
		/// <param name="apiKey">UWaterloo API Key</param>
		public UWaterlooApi(string apiKey) {
			_apiKey = apiKey;

			Foodservices = new FoodServicesApiService(apiKey);
		}
	}
}
