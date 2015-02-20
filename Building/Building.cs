using System.Collections.Generic;
using Newtonsoft.Json;
using UWaterlooApi.ApiRequest;

namespace UWaterlooAPI.Building
{
	/// <summary>
	/// Server API
	/// </summary>
	public class BuildingApi
	{
		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary> Default constructor </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public BuildingApi(string apiKey)
		{
			_apiKey = apiKey;
		}

	}
}
