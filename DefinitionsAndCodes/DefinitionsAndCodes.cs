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
	/// WARNING: Offical Documentation IS INCORRECT!
	/// </summary>
	public class Term
	{
		/// <summary> todo </summary>
		public string Abbreviation { get; set; }
		/// <summary> todo </summary>
		public string Description { get; set; }
	}

	/// <summary>
	/// todo
	/// </summary>
	public class Group
	{
		/// <summary> "Group Code" (Offical Documentation) </summary>
		[JsonProperty("group_code")]
		public string GroupCode { get; set; }
		/// <summary> "Group Short Name" (Offical Documentation) </summary>
		[JsonProperty("group_short_name")]
		public string GroupShortName { get; set; }
		/// <summary> "Full group name" (Offical Documentation) </summary>
		[JsonProperty("group_full_name")]
		public string GroupFullName { get; set; }
	}

	/// <summary>
	/// todo
	/// </summary>
	public class Subject
	{
		/// <summary> "Subject" (Offical Documentation) </summary>
		public string SubjectTitle { get; set; }
		/// <summary> "Description of subject" (Offical Documentation) </summary>
		public string Description { get; set; }
		/// <summary> "Subjects parent unit" (Offical Documentation) </summary>
		public string Unit { get; set; }
	}

	/// <summary>
	/// todo
	/// </summary>
	public class Instructions
	{
		/// <summary> "Abbreviation" (Offical Documentation) </summary>
		public string Abbreviation { get; set; }
		/// <summary> "Description" (Offical Documentation) </summary>
		public string Description { get; set; }
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
