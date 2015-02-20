using System.Collections.Generic;
using Newtonsoft.Json;
using UWaterlooApi.ApiRequest;

namespace UWaterlooAPI.Resources
{
	/// <summary>
	/// todo
	/// </summary>
	public class Tutor
	{
		/// <summary> "Subject acronym" (Offical Documentation) </summary>
		public string Subject { get; set; }
		/// <summary> "Course catalog number" (Offical Documentation) </summary>
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }
		/// <summary> "Course title" (Offical Documentation) </summary>
		public string Title { get; set; }
		/// <summary> "Total number of tutors available for that course" (Offical Documentation) </summary>
		[JsonProperty("tutors_count")]
		public int TutorsCoun { get; set; }	
		/// <summary> "Link to get tutor contact details" (Offical Documentation) </summary>
		[JsonProperty("contact_url")]
		public string ContactUrl { get; set; }
	}

	/// <summary>
	/// todo
	/// </summary>
	public class Printer
	{
		/// <summary> "Name of the printer" (Offical Documentation) </summary>
		[JsonProperty("printer")]
		public string PrinterName { get; set; }
		/// <summary> "Printers active directory id" (Offical Documentation) </summary>
		public string Ad { get; set; }
		/// <summary> "Printer server name" (Offical Documentation) </summary>
		public string Server { get; set; }
		/// <summary> "Additional comments on the printer" (Offical Documentation) </summary>
		public string Comment { get; set; }
		/// <summary> "Printer driver information" (Offical Documentation) </summary>
		public string Driver { get; set; }
		/// <summary> "Printer's physical room location" (Offical Documentation) </summary>
		public string Room { get; set; }
		/// <summary> "Faculty the printer belongs to" (Offical Documentation) </summary>
		public string Faculty { get; set; } 
	}

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
		/// "This method returns time information about the server" (Offical Documentation) 
		/// </summary>
		/// <returns></returns>
		public ApiRequest<List<Tutor>> Tutors()
		{
			return ApiRequest<List<Tutor>>.CreateApiRequest("/resources/tutors", _apiKey);
		}

		/// <summary>
		/// "This method returns a list of printer on campus" (Offical Documentation) 
		/// </summary>
		/// <returns></returns>
		public ApiRequest<List<Printer>> Printers()
		{
			return ApiRequest<List<Printer>>.CreateApiRequest("/resources/printers", _apiKey);
		}

	}
}
