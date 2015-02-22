using System.Collections.Generic;
using Newtonsoft.Json;
using UWaterlooApi.ApiRequest;

namespace UWaterlooAPI.Building
{
	/// <summary>
	/// Info about a building
	/// </summary>
	public class Building
	{
		/// <summary> "Official unique building number" (Official Documentation) </summary>
		[JsonProperty("building_id")]
		public int BuildingId { get; set; }
		/// <summary> "Official unique building code" (Official Documentation) </summary>
		[JsonProperty("building_code")]
		public string BuildingCode { get; set; }
		/// <summary> "Official unique building name" (Official Documentation) </summary>
		[JsonProperty("building_name")]
		public string BuildingName { get; set; }
		/// <summary> "Alternate building names" (Official Documentation) </summary>
		[JsonProperty("string")]
		public List<string> AlternateNames { get; set; }
		/// <summary> "Latitude of building location" (Official Documentation) </summary>
		public double Latitude { get; set; }
		/// <summary> "Longitude of building location" (Official Documentation) </summary>
		public double Longitude { get; set; }
		/// <summary> "List of building sections" (Official Documentation) </summary>
		[JsonProperty("BuildingSection")]
		public List<BuildingSection> BuildingSections { get; set; }
	}

	/// <summary>
	/// Info about a section in the building
	/// </summary>
	public class BuildingSection
	{
		/// <summary> "Name of section" (Official Documentation) </summary>
		[JsonProperty("section_name")]
		public string SectionName { get; set; }
		/// <summary> "Latitude of building section location" (Official Documentation) </summary>
		[JsonProperty("latitude")]
		public double Latitude { get; set; }
		/// <summary> "Longitude of building section location" (Official Documentation) </summary>
		[JsonProperty("longitude")]
		public double Longitude { get; set; }
	}

	/// <summary>
	/// Information about a course that would be relevant to the occupation of a room
	/// </summary>
	public class Course
	{
		/// <summary> "Class Number" (Official Documentation) </summary>
		[JsonProperty("class_number")]
		public int ClassNumber { get; set; }
		/// <summary> "Course subject code" (Official Documentation) </summary>
		public string Subject { get; set; }
		/// <summary> "Catalog number" (Official Documentation) </summary>
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }
		/// <summary> "Course title" (Official Documentation) </summary>
		public string Title { get; set; }
		/// <summary> "Course section number" (Official Documentation) </summary>
		public string Section { get; set; }
		/// <summary> "Course class days" (Official Documentation) </summary>
		public string Weekdays { get; set; }
		/// <summary> "Start time" (Official Documentation) </summary>
		[JsonProperty("start_time")]
		public string StartTime { get; set; }
		/// <summary> "End time" (Official Documentation) </summary>
		[JsonProperty("end_time")]
		public string EndTime { get; set; }
		/// <summary> "Start date" (Official Documentation) </summary>
		[JsonProperty("start_date")]
		public string StartDate { get; set; }
		/// <summary> "End date" (Official Documentation) </summary>
		[JsonProperty("end_date")]
		public string EndDate { get; set; }
		/// <summary> "Number of students currently enrolled in the section" (Official Documentation) </summary>
		[JsonProperty("enrollment_total")]
		public int EnrollmentTotal { get; set; }
		/// <summary> "List of instructors the individual meet" (Official Documentation) </summary>
		public List<string> Instructors { get; set; }
		/// <summary> "Building code of building where the individual meet is held" (Official Documentation) </summary>
		public string Building { get; set; }
		/// <summary> "Room where the individual meet is held" (Official Documentation) </summary>
		public string Room { get; set; }
		/// <summary> "Particular 4-month period within which sessions are defined" (Official Documentation) </summary>
		public int Term { get; set; }
		/// <summary> "Server time at last update (in ISO 8601 format)" (Official Documentation) </summary>
		[JsonProperty("last_updated")]
		public string LastUpdated { get; set; }
	}

	/// <summary>
	/// Building API
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

		/// <summary> 
		/// "Buildings" (Official Documentation)
		/// </summary>
		/// <returns> "This method returns a list of official building names, codes, numbers, and their lat/long coordinates." (Official Documentation) </returns>
		public ApiRequest<List<Building>> List()
		{
			return ApiRequest<List<Building>>.CreateApiRequest("/buildings/list", _apiKey);
		}

		/// <summary> 
		/// "Building Details" (Official Documentation)
		/// </summary>
		/// <returns> "This method returns the official building name, its unique number, and its lat/long coordinates given a building code." (Official Documentation) </returns>
		public ApiRequest<List<Building>> Building(string buildingCode)
		{
			return ApiRequest<List<Building>>.CreateApiRequest(string.Format("/buildings/{0}", buildingCode), _apiKey);
		}

		/// <summary> 
		/// "Courses in a Classroom" (Official Documentation)
		/// </summary>
		/// <returns> "This method gives out the all the courses offered in a given classroom." (Official Documentation) </returns>
		public ApiRequest<List<Building>> Courses(string building, string room)
		{
			return ApiRequest<List<Building>>.CreateApiRequest(string.Format("/buildings/{0}/{1}", building, room), _apiKey);
		}
	}
}
