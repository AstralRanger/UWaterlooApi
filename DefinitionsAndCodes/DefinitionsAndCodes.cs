using System.Collections.Generic;
using Newtonsoft.Json;
using UWaterlooApi.ApiRequest;
using UWaterlooApi.FoodServices;

namespace UWaterlooAPI.DefinitionsAndCodes
{
	/// <summary>
	/// Info about an organization unit.
	/// </summary>
	public class OrganizationalUnit
	{
		/// <summary> "Organizational Unit code" (Official Documentation) </summary>
		[JsonProperty("unit_code")]
		public string UnitCode { get; set; }
		/// <summary> "Unit's parent group" (Official Documentation) </summary>
		[JsonProperty("group_code")]
		public string GroupCode { get; set; }
		/// <summary> "Organizational Units short name" (Official Documentation) </summary>
		[JsonProperty("unit_short_name")]
		public string UnitShortName { get; set; }
		/// <summary> "Units full name" (Official Documentation) </summary>
		[JsonProperty("unit_full_name")]
		public string UnitFullName { get; set; }
	}

	/// <summary>
	/// Info about the naming convertion of a term
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
		/// <summary> "Group Code" (Official Documentation) </summary>
		[JsonProperty("group_code")]
		public string GroupCode { get; set; }
		/// <summary> "Group Short Name" (Official Documentation) </summary>
		[JsonProperty("group_short_name")]
		public string GroupShortName { get; set; }
		/// <summary> "Full group name" (Official Documentation) </summary>
		[JsonProperty("group_full_name")]
		public string GroupFullName { get; set; }
	}

	/// <summary>
	/// todo
	/// </summary>
	public class Subject
	{
		/// <summary> "Subject" (Official Documentation) </summary>
		public string SubjectTitle { get; set; }
		/// <summary> "Description of subject" (Official Documentation) </summary>
		public string Description { get; set; }
		/// <summary> "Subjects parent unit" (Official Documentation) </summary>
		public string Unit { get; set; }
	}

	/// <summary>
	/// todo
	/// </summary>
	public class Instructions
	{
		/// <summary> "Abbreviation" (Official Documentation) </summary>
		public string Abbreviation { get; set; }
		/// <summary> "Description" (Official Documentation) </summary>
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

		/// <summary>
		/// "Code Lookups for Organizational Units" (Official Documentation)
		/// </summary>
		/// <returns> "This method returns a list of all code lookups and their respective descriptions for organizations." (Official Documentation) </returns>
		public ApiRequest<List<OrganizationalUnit>> Units()
		{
			return ApiRequest<List<OrganizationalUnit>>.CreateApiRequest("/codes/units", _apiKey);
		}

		/// <summary>
		/// "Code Lookups for Terms" (Official Documentation)
		/// </summary>
		/// <returns> "This method returns a list of all code lookups for terms." (Official Documentation) </returns>
		public ApiRequest<List<Term>> Terms()
		{
			return ApiRequest<List<Term>>.CreateApiRequest("/codes/terms", _apiKey);
		}

		/// <summary>
		/// "Code Lookups for Groups" (Official Documentation)
		/// </summary>
		/// <returns> "This method returns a list of all code lookups for groups." (Official Documentation) </returns>
		public ApiRequest<List<Group>> Groups()
		{
			return ApiRequest<List<Group>>.CreateApiRequest("/codes/groups", _apiKey);
		}

		/// <summary> 
		/// "Code Lookups for subjects" (Official Documentation)
		/// </summary>
		/// <returns> "This method returns a list of all code lookups for subjects." (Official Documentation) </returns>
		public ApiRequest<List<Subject>> Subjects()
		{
			return ApiRequest<List<Subject>>.CreateApiRequest("/codes/subjects", _apiKey);
		}
		
		/// <summary> 
		/// "List of Instructions" (Official Documentation)
		/// </summary>
		/// <returns> "This method returns a list of Instructions." (Official Documentation) </returns>
		public ApiRequest<List<Instructions>> Instructions()
		{
			return ApiRequest<List<Instructions>>.CreateApiRequest("/codes/instructions", _apiKey);
		}
	}
}
