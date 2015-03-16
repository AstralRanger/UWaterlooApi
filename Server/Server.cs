// Copyright (c) Robinson Mann
// Licensed under the MIT License, See LICENSE.txt for more information.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace UWaterlooApi.Server
{

	/// <summary> "Server Error Codes" (Official Documentation) </summary> 
	public class ServerErrorCodes
	{
		/// <summary> "Numerical value of the Error code" (Official Documentation) </summary> 
		public int Code { get; set; }

		/// <summary> "Accompanying error message" (Official Documentation) </summary> 
		public string Message { get; set; }
	}

	/// <summary> "Server Time" (Official Documentation) </summary> 
	public class ServerTime
	{
		/// <summary> "Current UNIX timestamp" (Official Documentation) </summary> 
		public int Timestamp { get; set; }

		/// <summary> "ISO8601 compatible current server timestamp" (Official Documentation) </summary> 
		public string Datetime { get; set; }

		/// <summary> "Current server timezone" (Official Documentation) </summary> 
		public string Timezone { get; set; }

		/// <summary> "UNIX timestamp of when the api call quota will reset" (Official Documentation) </summary> 
		[JsonProperty("key_reset_time")]
		public int KeyResetTime { get; set; }
	}

	/// <summary> Server Endpoints </summary> 
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
		/// Official Method Name: Server Error Codes
		/// Description: This method returns a list of all possible API error codes
		/// Update Frequency: Every request
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<ServerErrorCodes>> ServerErrorCodes()
		{
			return ApiRequest<List<ServerErrorCodes>>.CreateApiRequest("/server/codes", _apiKey);
		}

		/// <summary>
		/// Official Method Name: Server Time
		/// Description: This method returns time information about the server
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<ServerTime>> ServerTime()
		{
			return ApiRequest<List<ServerTime>>.CreateApiRequest("/server/time", _apiKey);
		}

	}
}
