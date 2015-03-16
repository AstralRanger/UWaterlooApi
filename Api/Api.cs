// Copyright (c) Robinson Mann
// Licensed under the MIT License, See LICENSE.txt for more information.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace UWaterlooApi.Api
{

	/// <summary> "API Changelog" (Official Documentation) </summary> 
	public class ApiChangelog
	{
		/// <summary> "Y-m-d date of published changes" (Official Documentation) </summary> 
		public string Date { get; set; }

		/// <summary> "List of published changes" (Official Documentation) </summary> 
		public List<string> Changes { get; set; }
	}

	/// <summary> "API Methods List" (Official Documentation) </summary> 
	public class ApiMethodsList
	{
		/// <summary> "API assigned method ID" (Official Documentation) </summary> 
		[JsonProperty("method_id")]
		public int MethodId { get; set; }

		/// <summary> "API assigned method endpoint url" (Official Documentation) </summary> 
		[JsonProperty("method_url")]
		public string MethodUrl { get; set; }

		/// <summary> "API assigned method's parent service's id" (Official Documentation) </summary> 
		[JsonProperty("service_id")]
		public int ServiceId { get; set; }

		/// <summary> "API assigned method's parent service's name" (Official Documentation) </summary> 
		[JsonProperty("service_name")]
		public string ServiceName { get; set; }

		/// <summary> "String of acceptable method parameters" (Official Documentation) </summary> 
		public List<string> Parameters { get; set; }
	}

	/// <summary> "methods" (Official Documentation) </summary> 
	public class Methods
	{
		/// <summary> "API assigned method under service id" (Official Documentation) </summary> 
		[JsonProperty("method_id")]
		public string MethodId { get; set; }

		/// <summary> "API assigned method endpoint under service" (Official Documentation) </summary> 
		[JsonProperty("method_url")]
		public string MethodUrl { get; set; }
	}

	/// <summary> "API Services List" (Official Documentation) </summary> 
	public class ApiServicesList
	{
		/// <summary> "API assigned service ID" (Official Documentation) </summary> 
		[JsonProperty("service_id")]
		public int ServiceId { get; set; }

		/// <summary> "API assigned service name" (Official Documentation) </summary> 
		[JsonProperty("service_name")]
		public string ServiceName { get; set; }

		/// <summary> "API assigned service endpoint url" (Official Documentation) </summary> 
		[JsonProperty("service_url")]
		public string ServiceUrl { get; set; }

		/// <summary> "Available endpoints under the service" (Official Documentation) </summary> 
		public List<Methods> Methods { get; set; }
	}

	/// <summary> "API Usage Stats" (Official Documentation) </summary> 
	public class ApiUsageStats
	{
		/// <summary> "Developer's registered name" (Official Documentation) </summary> 
		public string Name { get; set; }

		/// <summary> "Developer assigned API key" (Official Documentation) </summary> 
		[JsonProperty("api_key")]
		public string ApiKey { get; set; }

		/// <summary> "Total calls made by the given key for the current month" (Official Documentation) </summary> 
		[JsonProperty("monthly_calls")]
		public int MonthlyCalls { get; set; }

		/// <summary> "Total calls made by the given key" (Official Documentation) </summary> 
		[JsonProperty("total_calls")]
		public int TotalCalls { get; set; }
	}

	/// <summary> "API Version Listings" (Official Documentation) </summary> 
	public class ApiVersionListings
	{
		/// <summary> "API version number" (Official Documentation) </summary> 
		public double Version { get; set; }

		/// <summary> "Y-m-d date for version release" (Official Documentation) </summary> 
		[JsonProperty("release_date")]
		public string ReleaseDate { get; set; }
	}

	/// <summary> Api Endpoints </summary> 
	public class ApiApi
	{

		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary> Default constructor </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public ApiApi(string apiKey)
		{
			_apiKey = apiKey;
		}

		/// <summary>
		/// Official Method Name: API Changelog
		/// Description: This method returns list of changes made to the API
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<ApiChangelog>> ApiChangelog()
		{
			return ApiRequest<List<ApiChangelog>>.CreateApiRequest("/api/changelog", _apiKey);
		}

		/// <summary>
		/// Official Method Name: API Methods List
		/// Description: This method returns all api endpoint methods available to use
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<ApiMethodsList>> ApiMethodsList()
		{
			return ApiRequest<List<ApiMethodsList>>.CreateApiRequest("/api/methods", _apiKey);
		}

		/// <summary>
		/// Official Method Name: API Services List
		/// Description: This method returns all api services available to use
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<ApiServicesList>> ApiServicesList()
		{
			return ApiRequest<List<ApiServicesList>>.CreateApiRequest("/api/services", _apiKey);
		}

		/// <summary>
		/// Official Method Name: API Usage Stats
		/// Description: This method returns user's api usage statistics
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<ApiUsageStats>> ApiUsageStats()
		{
			return ApiRequest<List<ApiUsageStats>>.CreateApiRequest("/api/usage", _apiKey);
		}

		/// <summary>
		/// Official Method Name: API Version Listings
		/// Description: This method returns user's api usage statistics
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<ApiVersionListings>> ApiVersionListings()
		{
			return ApiRequest<List<ApiVersionListings>>.CreateApiRequest("/api/versions", _apiKey);
		}

	}
}
