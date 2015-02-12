using System.Collections.Generic;
using Newtonsoft.Json;
using UWaterlooApi.ApiRequest;

namespace UWaterlooAPI.Courses
{
	/// <summary> "This method returns all the courses offered under a given subject" (Offical Documentation) </summary>
	public class CourseSubject
	{
		[JsonProperty("course_id")]
		public string CourseId { get; set; }
		public string Subject { get; set; }
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }
		public string Title { get; set; }
		public double Units { get; set; }
		public string Description { get; set; }
		[JsonProperty("academic_level")]
		public string AcademicLevel { get; set; }
	}

	/// <summary> "This method returns all available information for a given course" (Offical Documentation) </summary>
	public class CourseInformation
	{
		public string course_id { get; set; }
		public string subject { get; set; }
		public string catalog_number { get; set; }
		public string title { get; set; }
		public double units { get; set; }
		public string description { get; set; }
		public List<string> instructions { get; set; }
		public string prerequisites { get; set; }
		public string antirequisites { get; set; }
		public string corequisites { get; set; }
		public object crosslistings { get; set; }
		public List<string> terms_offered { get; set; }
		public string notes { get; set; }
		public Offerings offerings { get; set; }
		public bool needs_department_consent { get; set; }
		public bool needs_instructor_consent { get; set; }
		public List<object> extra { get; set; }
		public string calendar_year { get; set; }
		public string url { get; set; }
		public string academic_level { get; set; }
	}

	/// <summary> "Brief course description" (Offical Documentation) </summary>
	public class Offerings
	{
		public bool online { get; set; }
		public bool online_only { get; set; }
		public bool st_jerome { get; set; }
		public bool st_jerome_only { get; set; }
		public bool renison { get; set; }
		public bool renison_only { get; set; }
		public bool conrad_grebel { get; set; }
		public bool conrad_grebel_only { get; set; }
	}

	/// <summary>
	/// todo
	/// </summary>
	public class CoursesApi
	{
		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary> Default constructor </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public CoursesApi(string apiKey)
		{
			_apiKey = apiKey;
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <returns></returns>
		public ApiRequest<CourseSubject> Subject(string subject)
		{
			return ApiRequest<CourseSubject>.CreateApiRequest(string.Concat("/courses", "/", subject), _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <returns></returns>
		public ApiRequest<CourseInformation> CourseInformation(string courseId)
		{
			return ApiRequest<CourseInformation>.CreateApiRequest(string.Concat("/courses", "/", courseId), _apiKey);
		}
	}
}
