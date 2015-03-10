using System.Net;
using Newtonsoft.Json;
using UWaterlooApi.FoodServices;
using UWaterlooApi.Courses;
using UWaterlooApi.Events;
using UWaterlooApi.News;
using UWaterlooApi.Weather;
using UWaterlooApi.Terms;
using UWaterlooApi.Resources;
using UWaterlooApi.DefinitionsAndCodes;
using UWaterlooApi.Buildings;
using UWaterlooApi.Api;
using UWaterlooApi.Server;

namespace UWaterlooApi
{
	/// <summary>
	/// UWaterlooAPI Class
	/// </summary>
    public class UWaterlooApi
    {
		/// Api endpoints
		public readonly FoodServicesApi FoodServices;
		public readonly CoursesApi Courses;
		public readonly EventsApi Events;
		public readonly NewsApi News;
		public readonly WeatherApi Weather;
		public readonly TermsApi Terms;
		public readonly ResourcesApi Resources;
		public readonly DefinitionsAndCodesApi DefinitionsAndCodes;
		public readonly BuildingsApi Buildings;
		public readonly ApiApi Api;
		public readonly ServerApi Server;

		/// <summary>
		/// Default constructor 
		/// </summary>
		/// <param name="apiKey">UWaterloo API Key</param>
		public UWaterlooApi(string apiKey) {

			// Initializing endpoints
			FoodServices = new FoodServicesApi(apiKey);
			Courses = new CoursesApi(apiKey);
			Events = new EventsApi(apiKey);
			News = new NewsApi(apiKey);
			Weather = new WeatherApi(apiKey);
			Terms = new TermsApi(apiKey);
			Resources = new ResourcesApi(apiKey);
			DefinitionsAndCodes = new DefinitionsAndCodesApi(apiKey);
			Buildings = new BuildingsApi(apiKey);
			Api = new ApiApi(apiKey);
			Server = new ServerApi(apiKey);

		}
	}

	/// <summary>
	/// Meta information from each function call
	/// </summary>
	public class Meta
	{
		public int Requests, Timestamp, Status, MethodId, Version;
		public string Message;
	}

	/// <summary>
	/// API Call wrapper. 
	/// </summary>
	/// <typeparam name="T"> Class corresponding to "data" in the APIs returned JSON feed </typeparam>
	public class ApiRequest<T> where T : new()
	{
		public Meta Meta;
		public T Data;

		/// <summary>
		/// Default Constructor
		/// </summary>
		public ApiRequest()
		{
			Meta = new Meta();
			Data = new T();
		}

		/// <summary>
		/// Calls Api Endpoint and maps it ApiRequest T
		/// </summary>
		/// <param name="endpoint">The API endpoint to call (Should start with / and NOT include file format) </param>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public static ApiRequest<T> CreateApiRequest(string endpoint, string apiKey)
		{
			string json;

			using (var webClient = new WebClient())
			{
				json = webClient.DownloadString(string.Format("http://api.uwaterloo.ca/v2{0}.json?key={1}", endpoint, apiKey));
			}

			return JsonConvert.DeserializeObject<ApiRequest<T>>(json);
		}
	}
}
