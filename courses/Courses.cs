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
		[JsonProperty("course_id")]
		public string CourseId { get; set; }
		public string Subject { get; set; }
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }
		public string Title { get; set; }
		public double Units { get; set; }
		public string Description { get; set; }
		public List<string> Instructions { get; set; }
		public string Prerequisites { get; set; }
		public string Antirequisites { get; set; }
		public string Corequisites { get; set; }
		public object Crosslistings { get; set; }
		[JsonProperty("terms_offered")]
		public List<string> TermsOffered { get; set; }
		public string Notes { get; set; }
		public Offerings Offerings { get; set; }
		[JsonProperty("needs_department_consent")]
		public bool NeedsDepartmentConsent { get; set; }
		[JsonProperty("needs_instructor_consent")]
		public bool NeedsInstructorConsent { get; set; }
		public List<object> Extra { get; set; }
		[JsonProperty("calendar_year")]
		public string CalendarYear { get; set; }
		public string Url { get; set; }
		[JsonProperty("academic_level")]
		public string AcademicLevel { get; set; }
	}

	/// <summary> "Brief course description" (Offical Documentation) </summary>
	public class Offerings
	{
		[JsonProperty("online")]
		public bool Online { get; set; }
		[JsonProperty("online_only")]
		public bool OnlineOnly { get; set; }
		[JsonProperty("st_jerome")]
		public bool StJerome { get; set; }
		[JsonProperty("st_jerome_only")]
		public bool StJeromeOnly { get; set; }
		[JsonProperty("renison")]
		public bool Renison { get; set; }
		[JsonProperty("renison_only")]
		public bool RenisonOnly { get; set; }
		[JsonProperty("conrad_grebel")]
		public bool ConradGrebel { get; set; }
		[JsonProperty("conrad_grebel_only")]
		public bool ConradGrebelOnly { get; set; }
	}

	/// <summary> "This method returns the class schedule for a given course and term" (Offical Documentation) </summary>
	public class CourseSchedule
	{
		public string Subject { get; set; }
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }
		public double Units { get; set; }
		public string Title { get; set; }
		public object Note { get; set; }
		[JsonProperty("class_number")]
		public int ClassNumber { get; set; }
		public string Section { get; set; }
		public string Campus { get; set; }
		[JsonProperty("associated_class")]
		public int AssociatedClass { get; set; }
		[JsonProperty("related_component_1")]
		public object RelatedComponent1 { get; set; }
		[JsonProperty("related_component_2")]
		public object RelatedComponent2 { get; set; }
		[JsonProperty("enrollment_capacity")]
		public int EnrollmentCapacity { get; set; }
		[JsonProperty("enrollment_total")]
		public int EnrollmentTotal { get; set; }
		[JsonProperty("waiting_capacity")]
		public int WaitingCapacity { get; set; }
		[JsonProperty("waiting_total")]
		public int WaitingTotal { get; set; }
		public object Topic { get; set; }
		public List<object> Reserves { get; set; }
		public List<Class> Classes { get; set; }
		[JsonProperty("held_with")]
		public List<string> HeldWith { get; set; }
		public int Term { get; set; }
		[JsonProperty("academic_level")]
		public string AcademicLevel { get; set; }
		[JsonProperty("last_updated")]
		public string LastUpdated { get; set; }
	}

	public class Dates
	{
		[JsonProperty("start_time")]
		public string StartTime { get; set; }
		[JsonProperty("end_time")]
		public string EndTime { get; set; }
		public string Weekdays { get; set; }
		[JsonProperty("start_date")]
		public object StartDate { get; set; }
		[JsonProperty("end_date")]
		public object EndDate { get; set; }
		[JsonProperty("_tba")]
		public bool IsTba { get; set; }
		[JsonProperty("is_cancelled")]
		public bool IsCancelled { get; set; }
		[JsonProperty("is_closed")]
		public bool IsClosed { get; set; }
	}

	public class Location
	{
		public string Building { get; set; }
		public string Room { get; set; }
	}

	public class Class
	{
		public Dates Dates { get; set; }
		public Location Location { get; set; }
		public List<string> Instructors { get; set; }
	}

	public class CoursePrerequisites
	{
		public string Subject { get; set; }
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }
		public string Title { get; set; }
		public string Prerequisites { get; set; }
		[JsonProperty("prerequisites_parsed")]
		public List<List<object>> PrerequisitesParsed { get; set; }
	}

	public class CourseSection
	{
		public string Section { get; set; }
		public string Day { get; set; }
		public string Date { get; set; }
		[JsonProperty("start_time")]
		public string StartTime { get; set; }
		[JsonProperty("end_time")]
		public string EndTime { get; set; }
		public string Location { get; set; }
		public string Notes { get; set; }
	}

	public class ExamSchedule
	{
		public string Course { get; set; }
		public List<CourseSection> Sections { get; set; }
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
		/// <param name="subject"></param>
		/// <returns></returns>
		public ApiRequest<CourseSubject> Subject(string subject)
		{
			return ApiRequest<CourseSubject>.CreateApiRequest(string.Concat("/courses/", subject), _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <param name="courseId"></param>
		/// <returns></returns>
		public ApiRequest<CourseInformation> CourseInformation(string courseId)
		{
			return ApiRequest<CourseInformation>.CreateApiRequest(string.Concat("/courses/", courseId), _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <param name="classNumber"></param>
		/// <returns></returns>
		public ApiRequest<List<CourseInformation>> CourseSchedule(string classNumber)
		{
			return ApiRequest<List<CourseInformation>>.CreateApiRequest(string.Concat("/courses/", classNumber, "/schedule"), _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <param name="subject"></param>
		/// <param name="catalogNumber"></param>
		/// <returns></returns>
		public ApiRequest<CourseInformation> CourseInformation(string subject, string catalogNumber)
		{
			return ApiRequest<CourseInformation>.CreateApiRequest(string.Concat("/courses/", subject, "/", catalogNumber), _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <param name="subject"></param>
		/// <param name="catalogNumber"></param>
		/// <returns></returns>
		public ApiRequest<List<CourseInformation>> CourseSchedule(string subject, string catalogNumber)
		{
			return ApiRequest<List<CourseInformation>>.CreateApiRequest(string.Concat("/courses/", subject, "/", catalogNumber, "/schedule"), _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <param name="subject"></param>
		/// <param name="catalogNumber"></param>
		/// <returns></returns>
		public ApiRequest<CoursePrerequisites> CoursePrerequisites(string subject, string catalogNumber)
		{
			return ApiRequest<CoursePrerequisites>.CreateApiRequest(string.Concat("/courses/", subject, "/", catalogNumber, "/prerequisites"), _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <param name="subject"></param>
		/// <param name="catalogNumber"></param>
		/// <returns></returns>
		public ApiRequest<CoursePrerequisites> ExamSchedule(string subject, string catalogNumber)
		{
			return ApiRequest<CoursePrerequisites>.CreateApiRequest(string.Concat("/courses/", subject, "/", catalogNumber, "/examschedule"), _apiKey);
		}
	}
}
