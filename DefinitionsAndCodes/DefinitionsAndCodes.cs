using System.Collections.Generic;
using Newtonsoft.Json;
using UWaterlooApi.ApiRequest;

namespace UWaterlooAPI.DefinitionsAndCodes
{
	/// <summary>
	/// todo
	/// </summary>
	public class OrganizationalUnit
	{
		/// <summary> "Organizational Unit code" (Offical Documentation) </summary>
		[JsonProperty("unit_code")]
		public string UnitCode { get; set; }
		/// <summary> "Unit's parent group" (Offical Documentation) </summary>
		[JsonProperty("group_code")]
		public string GroupCode { get; set; }
		/// <summary> "Organizational Units short name" (Offical Documentation) </summary>
		[JsonProperty("unit_short_name")]
		public string UnitShortName { get; set; }
		/// <summary> "Units full name" (Offical Documentation) </summary>
		[JsonProperty("unit_full_name")]
		public string UnitFullName { get; set; }
	}

	/// <summary>
	/// todo
	/// </summary>
	public class DefinitionsAndCodesApi
	{
		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary> Default constructor </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public DefinitionsAndCodesApi(string apiKey)
		{
			_apiKey = apiKey;
		}
	}
}
