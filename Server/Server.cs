using System.Collections.Generic;
using Newtonsoft.Json;
using UWaterlooApi.ApiRequest;

namespace UWaterlooAPI.Server
{
	/// <summary>
	/// Info about the current time
	/// </summary>
	public class Time
	{
		/// <summary> "Current UNIX timestamp" (Offical Documentation) </summary>
		public int Timestamp { get; set; }
		/// <summary> "ISO8601 compatible current server timestamp" (Offical Documentation) </summary>
		[JsonProperty("datetime")]
		public string Datetime { get; set; }
		/// <summary> "Current server timezone" (Offical Documentation) </summary>
		[JsonProperty("timezone")]
		public string Timezone { get; set; }
		/// <summary> "UNIX timestamp of when the api call quota will reset" (Offical Documentation) </summary>
		[JsonProperty("key_reset_time")]
		public int KeyResetTime { get; set; }
	}

	/// <summary>
	/// Status code
	/// </summary>
	public class InfoCode
	{
		///<summary> "Numerical value of the Error code" (Offical Documentation) </summary>
		public int Code { get; set; }
		///<summary> "Accompanying error message" (Offical Documentation) </summary>
		public string Message { get; set; }
	}

	/// <summary>
	/// Server API
	/// </summary>
	public class ServerApi
	{
		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary> Default constructor </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public ServerApi(string apiKey)
		{
			_apiKey = apiKey;
		}

		/// <summary>
		/// "This method returns time information about the server" (Offical Documentation) 
		/// </summary>
		/// <returns></returns>
		public ApiRequest<Time> Time()
		{
			return ApiRequest<Time>.CreateApiRequest("/server/codes", _apiKey);
		}

		/// <summary>
		/// "This method returns a list of all possible API error codes" (Offical Documentation) 
		/// </summary>
		/// <returns></returns>
		public ApiRequest<List<InfoCode>> Codes()
		{
			return ApiRequest<List<InfoCode>>.CreateApiRequest("/server/codes", _apiKey);
		}
	}
}
