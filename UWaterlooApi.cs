﻿/* By Robinson Mann 
 * Licensed under the MIT License, See LICENSE.txt for more information. */

using System.Net;
using Newtonsoft.Json;
using UWaterlooApi.Api;
using UWaterlooApi.Buildings;
using UWaterlooApi.Courses;
using UWaterlooApi.DefinitionsAndCodes;
using UWaterlooApi.Events;
using UWaterlooApi.FoodServices;
using UWaterlooApi.News;
using UWaterlooApi.Resources;
using UWaterlooApi.Server;
using UWaterlooApi.Terms;
using UWaterlooApi.Weather;

namespace UWaterlooApi
{
	/// <summary>
	/// UWaterlooAPI Class
	/// </summary>
	public class UWaterlooApi
	{
		/// <summary>
		/// Food Services Endpoints
		/// </summary>
		public readonly FoodServicesApi FoodServices;

		/// <summary>
		/// Courses Endpoints
		/// </summary>
		public readonly CoursesApi Courses;

		/// <summary>
		/// Event Endpoints
		/// </summary>
		public readonly EventsApi Events;

		/// <summary>
		/// New Endpoints
		/// </summary>
		public readonly NewsApi News;

		/// <summary>
		/// Weather Endpoints
		/// </summary>
		public readonly WeatherApi Weather;

		/// <summary>
		/// Terms Endpoints
		/// </summary>
		public readonly TermsApi Terms;

		/// <summary>
		/// Resources Endpoints
		/// </summary>
		public readonly ResourcesApi Resources;

		/// <summary>
		/// Definitions and Codes Endpoints
		/// </summary>
		public readonly DefinitionsAndCodesApi DefinitionsAndCodes;

		/// <summary>
		/// Buildings Endpoints
		/// </summary>
		public readonly BuildingsApi Buildings;

		/// <summary>
		/// Api Endpoints
		/// </summary>
		public readonly ApiApi Api;

		/// <summary>
		/// Server Endpoints
		/// </summary>
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
		/// <summary> Number of requests the current API key has made in the current month  </summary>
		public int Requests;

		/// <summary> Unix timestamp </summary>
		public int Timestamp;

		/// <summary> Status code of API call </summary>
		public int Status;

		/// <summary></summary>
		public int Version;

		/// <summary> Method ID associated with endpoint </summary>
		[JsonProperty("Method_Id")]
		public int MethodId;

		/// <summary> A string describing the status of the API call </summary>
		public string Message;
	}

	/// <summary>
	/// API Call wrapper. 
	/// </summary>
	/// <typeparam name="T"> Class corresponding to "data" in the APIs returned JSON feed </typeparam>
	public class ApiRequest<T> where T : new()
	{
		/// <summary>
		/// Meta data from API call
		/// </summary>
		public Meta Meta;

		/// <summary>
		/// Relevent data from API call
		/// </summary>
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
