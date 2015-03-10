// Copyright (c) Robinson Mann
// Licensed under the MIT License, See LICENSE.txt for more information.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace uWaterlooApi.Buildings
{

	/// <summary> "building_sections" (Official Documentation) </summary> 
	public class BuildingSections
	{
		/// <summary> "Name of section" (Official Documentation) </summary> 
		[JsonProperty("section_name")]
		public List<string> SectionName { get; set; }

		/// <summary> "Latitude of building section location" (Official Documentation) </summary> 
		public double Latitude { get; set; }

		/// <summary> "Longitude of building section location" (Official Documentation) </summary> 
		public double Longitude { get; set; }
	}

	/// <summary> "Building Details" (Official Documentation) </summary> 
	public class BuildingDetails
	{
		/// <summary> "Unique building number" (Official Documentation) </summary> 
		[JsonProperty("building_id")]
		public string BuildingId { get; set; }

		/// <summary> "Official building name" (Official Documentation) </summary> 
		[JsonProperty("building_code")]
		public string BuildingCode { get; set; }

		/// <summary> "Alternate building names" (Official Documentation) </summary> 
		[JsonProperty("alternate_names")]
		public List<string> AlternateNames { get; set; }

		/// <summary> "Latitude of building location" (Official Documentation) </summary> 
		public double Latitude { get; set; }

		/// <summary> "Longitude of building location" (Official Documentation) </summary> 
		public double Longitude { get; set; }

		/// <summary> "List of building sections" (Official Documentation) </summary> 
		[JsonProperty("building_sections")]
		public List<BuildingSections> BuildingSections { get; set; }
	}

	/// <summary> "Courses in a Classroom" (Official Documentation) </summary> 
	public class CoursesInAClassroom
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
	
	/// <summary> "Buildings" (Official Documentation) </summary> 
	public class Buildings
	{
		/// <summary> "Unique building number" (Official Documentation) </summary> 
		[JsonProperty("building_id")]
		public string BuildingId { get; set; }

		/// <summary> "Official building name" (Official Documentation) </summary> 
		[JsonProperty("building_code")]
		public string BuildingCode { get; set; }

		/// <summary> "Alternate building names" (Official Documentation) </summary> 
		[JsonProperty("alternate_names")]
		public List<string> AlternateNames { get; set; }

		/// <summary> "Latitude of building location" (Official Documentation) </summary> 
		public double Latitude { get; set; }

		/// <summary> "Longitude of building location" (Official Documentation) </summary> 
		public double Longitude { get; set; }

		/// <summary> "List of building sections" (Official Documentation) </summary> 
		[JsonProperty("building_sections")]
		public List<BuildingSections> BuildingSections { get; set; }
	}

	/// <summary> Buildings Endpoints </summary> 
	public class BuildingsApi
	{

		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary> Default constructor </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public BuildingsApi(string apiKey)
		{
			_apiKey = apiKey;
		}

		/// <summary>
		/// Official Method Name: Building Details
		/// Description: This method returns the official building name, its unique number, and its lat/long coordinates given a building code.
		/// Update Frequency: When updated by the steward/via github pull request
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<BuildingDetails>> BuildingDetails(string buildingCode)
		{
			return ApiRequest<List<BuildingDetails>>.CreateApiRequest(string.Format("/buildings/{0}", buildingCode), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Courses in a Classroom
		/// Description: This method gives out the all the courses offered in a given classroom.
		/// Update Frequency: Every hour on weekdays
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<CoursesInAClassroom>> CoursesInAClassroom(string building, int room)
		{
			return ApiRequest<List<CoursesInAClassroom>>.CreateApiRequest(string.Format("/buildings/{0}/{1}/courses", building, room), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Buildings
		/// Description: This method returns a list of official building names, their unique number and their lat/long coordinates.
		/// Update Frequency: When updated by the steward/via github pull request
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<Buildings>> Buildings()
		{
			return ApiRequest<List<Buildings>>.CreateApiRequest("/buildings/list", _apiKey);
		}

	}
}
