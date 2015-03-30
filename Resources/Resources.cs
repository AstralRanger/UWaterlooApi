/* By Robinson Mann 
 * Licensed under the MIT License, See LICENSE.txt for more information. */

using System.Collections.Generic;
using Newtonsoft.Json;

namespace UWaterlooApi.Resources
{

	/// <summary> "List of student tutors available" (Official Documentation) </summary> 
	public class ListOfStudentTutorsAvailable
	{
		/// <summary> "Subject acronym" (Official Documentation) </summary> 
		public string Subject { get; set; }

		/// <summary> "Course catalog number" (Official Documentation) </summary> 
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }

		/// <summary> "Course title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "Total number of tutors available for that course" (Official Documentation) </summary> 
		[JsonProperty("tutors_count")]
		public int? TutorsCount { get; set; }

		/// <summary> "Link to get tutor contact details" (Official Documentation) </summary> 
		[JsonProperty("contact_url")]
		public string ContactUrl { get; set; }
	}

	/// <summary> "List of geese nests" (Official Documentation) </summary> 
	public class ListOfGeeseNests
	{
		/// <summary> "Goose Nest ID" (Official Documentation) </summary> 
		public string Id { get; set; }

		/// <summary> "Human-readable description of goose nest location" (Official Documentation) </summary> 
		public string Location { get; set; }

		/// <summary> "Latitude of goose nest location" (Official Documentation) </summary> 
		public double? Latitude { get; set; }

		/// <summary> "Longitude of goose nest location" (Official Documentation) </summary> 
		public double? Longitude { get; set; }

		/// <summary> "ISO 8601 time-stamp of last update" (Official Documentation) </summary> 
		public string Updated { get; set; }
	}

	/// <summary> "List of coop infosessions" (Official Documentation) </summary> 
	public class ListOfCoopInfosessions
	{
		/// <summary> "Session ID" (Official Documentation) </summary> 
		public string Id { get; set; }

		/// <summary> "Name of the company/employer" (Official Documentation) </summary> 
		public string Employer { get; set; }

		/// <summary> "Session date" (Official Documentation) </summary> 
		public string Date { get; set; }

		/// <summary> "Session start time" (Official Documentation) </summary> 
		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		/// <summary> "Session end time" (Official Documentation) </summary> 
		[JsonProperty("end_time")]
		public string EndTime { get; set; }

		/// <summary> "Session campus location" (Official Documentation) </summary> 
		public string Location { get; set; }

		/// <summary> "Employer's website" (Official Documentation) </summary> 
		public string Website { get; set; }

		/// <summary> "Intended student audience" (Official Documentation) </summary> 
		public string Audience { get; set; }

		/// <summary> "Intended programs for student audience" (Official Documentation) </summary> 
		public string Programs { get; set; }

		/// <summary> "Information about the session" (Official Documentation) </summary> 
		public string Description { get; set; }
	}

	/// <summary> "List of Campus Printer" (Official Documentation) </summary> 
	public class ListOfCampusPrinter
	{
		/// <summary> "Name of the printer" (Official Documentation) </summary> 
		public string Printer { get; set; }

		/// <summary> "Printers active directory id" (Official Documentation) </summary> 
		public string Ad { get; set; }

		/// <summary> "Printer server name" (Official Documentation) </summary> 
		public string Server { get; set; }

		/// <summary> "Additional comments on the printer" (Official Documentation) </summary> 
		public string Comment { get; set; }

		/// <summary> "Printer driver information" (Official Documentation) </summary> 
		public string Driver { get; set; }

		/// <summary> "Printer's physical room location" (Official Documentation) </summary> 
		public string Room { get; set; }

		/// <summary> "Faculty the printer belongs to" (Official Documentation) </summary> 
		public string Faculty { get; set; }
	}

	/// <summary> Resources Endpoints </summary> 
	public class ResourcesApi
	{

		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary> Default constructor </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public ResourcesApi(string apiKey)
		{
			_apiKey = apiKey;
		}

		/// <summary>
		/// Official Method Name: List of student tutors available
		/// Description: This method returns a list of all the tutors available to help for a course for a given term
		/// Update Frequency: As the data updates by SSO
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<ListOfStudentTutorsAvailable>> ListOfStudentTutorsAvailable()
		{
			return ApiRequest<List<ListOfStudentTutorsAvailable>>.CreateApiRequest("/resources/tutors", _apiKey);
		}

		/// <summary>
		/// Official Method Name: List of geese nests
		/// Description: This method returns a list of geese nests during their spring mating season
		/// Update Frequency: When updated by pull request
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<ListOfGeeseNests>> ListOfGeeseNests()
		{
			return ApiRequest<List<ListOfGeeseNests>>.CreateApiRequest("/resources/goosewatch", _apiKey);
		}

		/// <summary>
		/// Official Method Name: List of coop infosessions
		/// Description: This method returns a list of campus employer infosessions
		/// Update Frequency: When updated by pull request
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<ListOfCoopInfosessions>> ListOfCoopInfosessions()
		{
			return ApiRequest<List<ListOfCoopInfosessions>>.CreateApiRequest("/resources/infosessions", _apiKey);
		}

		/// <summary>
		/// Official Method Name: List of Campus Printer
		/// Description: This method returns a list of printer on campus
		/// Update Frequency: When updated by pull request
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<ListOfCampusPrinter>> ListOfCampusPrinter()
		{
			return ApiRequest<List<ListOfCampusPrinter>>.CreateApiRequest("/resources/printers", _apiKey);
		}

	}
}
