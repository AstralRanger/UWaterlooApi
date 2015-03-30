/* By Robinson Mann 
 * Licensed under the MIT License, See LICENSE.txt for more information. */

using System.Collections.Generic;
using Newtonsoft.Json;

namespace UWaterlooApi.DefinitionsAndCodes
{

	/// <summary> "Code Lookups for Groups" (Official Documentation) </summary> 
	public class CodeLookupsForGroups
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

	/// <summary> "List of Instructions" (Official Documentation) </summary> 
	public class ListOfInstructions
	{
		/// <summary> "Abbreviation" (Official Documentation) </summary> 
		public string Abbreviation { get; set; }

		/// <summary> "Description" (Official Documentation) </summary> 
		public string Description { get; set; }
	}

	/// <summary> "Code Lookups for subjects" (Official Documentation) </summary> 
	public class CodeLookupsForSubjects
	{
		/// <summary> "Subject" (Official Documentation) </summary> 
		public string Subject { get; set; }

		/// <summary> "Description of subject" (Official Documentation) </summary> 
		public string Description { get; set; }

		/// <summary> "Subjects parent unit" (Official Documentation) </summary> 
		public string Unit { get; set; }
	}

	/// <summary> "Code Lookups for Terms" (Official Documentation) </summary> 
	public class CodeLookupsForTerms
	{
		/// <summary> "Term" (Official Documentation) </summary> 
		public string Term { get; set; }

		/// <summary> "Description of term" (Official Documentation) </summary> 
		public string Description { get; set; }
	}

	/// <summary> "Code Lookups for Organizational Units" (Official Documentation) </summary> 
	public class CodeLookupsForOrganizationalUnits
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

	/// <summary> Definitions And Codes Endpoints </summary> 
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
		/// Official Method Name: Code Lookups for Groups
		/// Description: This method returns a list of all code lookups for groups.
		/// Update Frequency: When updated by steward/via pull request
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<CodeLookupsForGroups>> CodeLookupsForGroups()
		{
			return ApiRequest<List<CodeLookupsForGroups>>.CreateApiRequest("/codes/groups", _apiKey);
		}

		/// <summary>
		/// Official Method Name: List of Instructions
		/// Description: This method returns a list of Instructions.
		/// Update Frequency: When updated by steward/via pull request
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<ListOfInstructions>> ListOfInstructions()
		{
			return ApiRequest<List<ListOfInstructions>>.CreateApiRequest("/codes/instructions", _apiKey);
		}

		/// <summary>
		/// Official Method Name: Code Lookups for subjects
		/// Description: This method returns a list of all code lookups for subjects.
		/// Update Frequency: When updated by steward/via pull request
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<CodeLookupsForSubjects>> CodeLookupsForSubjects()
		{
			return ApiRequest<List<CodeLookupsForSubjects>>.CreateApiRequest("/codes/subjects", _apiKey);
		}

		/// <summary>
		/// Official Method Name: Code Lookups for Terms
		/// Description: This method returns a list of all code lookups for terms.
		/// Update Frequency: When updated by steward/via pull request
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<CodeLookupsForTerms>> CodeLookupsForTerms()
		{
			return ApiRequest<List<CodeLookupsForTerms>>.CreateApiRequest("/codes/terms", _apiKey);
		}

		/// <summary>
		/// Official Method Name: Code Lookups for Organizational Units
		/// Description: This method returns a list of all code lookups and their respective descriptions for organizations.
		/// Update Frequency: When updated by steward/via pull request
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<CodeLookupsForOrganizationalUnits>> CodeLookupsForOrganizationalUnits()
		{
			return ApiRequest<List<CodeLookupsForOrganizationalUnits>>.CreateApiRequest("/codes/units", _apiKey);
		}

	}
}
