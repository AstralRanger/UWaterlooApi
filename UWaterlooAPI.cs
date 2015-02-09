using UWaterlooAPI.FoodServices;

namespace UWaterlooAPI
{
	/// <summary>
	/// UWaterlooAPI Class
	/// </summary>
    public class UWaterlooApi
    {
		// Your API key
		readonly string _apiKey;

		/// <summary>
		/// Meta information from each function call
		/// "method" not implemented
		/// </summary>
		public class Meta
		{
			public int Requests, Timestamp, Status, MethodId, Version;
			public string Message;
		}

		/// <summary>
		/// An API wrapper. Contains two classes, the first is the API calls meta information, 
		/// and the second is the 'data' class that the API call returned.
		/// </summary>
		/// <typeparam name="T">The type of data that the API call returns</typeparam>
		public class ApiCall<T> where T : new() {
			public Meta	Meta;
			public T	Data;

			/// <summary>
			/// Default Constructor
			/// </summary>
			public ApiCall () {
				Meta = new Meta();
				Data = new T();
			}
		}
				
		
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
