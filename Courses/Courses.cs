/* By Robinson Mann */

using System.Collections.Generic;
using Newtonsoft.Json;

namespace UWaterlooApi.Courses
{

	/// <summary> "reserves" (Official Documentation) </summary> 
	public class Reserves
	{
		/// <summary> "Name of the reserved group" (Official Documentation) </summary> 
		[JsonProperty("reserve_group")]
		public string ReserveGroup { get; set; }

		/// <summary> "Total enrollment capacity of the group" (Official Documentation) </summary> 
		[JsonProperty("enrollment_capacity")]
		public int? EnrollmentCapacity { get; set; }

		/// <summary> "Total reserve enrollment" (Official Documentation) </summary> 
		[JsonProperty("enrollment_total")]
		public int? EnrollmentTotal { get; set; }
	}

	/// <summary> "date" (Official Documentation) </summary> 
	public class Date
	{
		/// <summary> "24 hour class starting time" (Official Documentation) </summary> 
		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		/// <summary> "24 hour class ending time" (Official Documentation) </summary> 
		[JsonProperty("end_time")]
		public string EndTime { get; set; }

		/// <summary> "Weekdays the course is offered" (Official Documentation) </summary> 
		public string Weekdays { get; set; }

		/// <summary> "Additional starting date for course" (Official Documentation) </summary> 
		[JsonProperty("start_date")]
		public string StartDate { get; set; }

		/// <summary> "Additional ending date for course" (Official Documentation) </summary> 
		[JsonProperty("end_date")]
		public string EndDate { get; set; }

		/// <summary> "If the course schedule is TBA" (Official Documentation) </summary> 
		[JsonProperty("is_tba")]
		public bool? IsTba { get; set; }

		/// <summary> "If the course is cancelled for the term" (Official Documentation) </summary> 
		[JsonProperty("is_cancelled")]
		public bool? IsCancelled { get; set; }

		/// <summary> "If the course is closed for the term" (Official Documentation) </summary> 
		[JsonProperty("is_closed")]
		public bool? IsClosed { get; set; }
	}

	/// <summary> "Course Schedule by Class Number" (Official Documentation) </summary> 
	public class CourseScheduleByClassNumber
	{
		/// <summary> "Requested subject acronym" (Official Documentation) </summary> 
		public string Subject { get; set; }

		/// <summary> "Registrar assigned class number" (Official Documentation) </summary> 
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }

		/// <summary> "Credit count for the mentioned course" (Official Documentation) </summary> 
		public double? Units { get; set; }

		/// <summary> "Class name and title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "Additional notes regarding enrollment for the given term" (Official Documentation) </summary> 
		public string Note { get; set; }

		/// <summary> "Associated term specific class enrollment number" (Official Documentation) </summary> 
		[JsonProperty("class_number")]
		public int? ClassNumber { get; set; }

		/// <summary> "Class instruction and number" (Official Documentation) </summary> 
		public string Section { get; set; }

		/// <summary> "Name of the campus the course is being offered" (Official Documentation) </summary> 
		public string Campus { get; set; }

		/// <summary> "Associated class id" (Official Documentation) </summary> 
		[JsonProperty("associated_class")]
		public int? AssociatedClass { get; set; }

		/// <summary> "Name of the related course component" (Official Documentation) </summary> 
		[JsonProperty("related_component_1")]
		public string RelatedComponent1 { get; set; }

		/// <summary> "Name of the second related course component" (Official Documentation) </summary> 
		[JsonProperty("related_component_2")]
		public string RelatedComponent2 { get; set; }

		/// <summary> "Class enrollment capacity" (Official Documentation) </summary> 
		[JsonProperty("enrollment_capacity")]
		public int? EnrollmentCapacity { get; set; }

		/// <summary> "Total current class enrollment" (Official Documentation) </summary> 
		[JsonProperty("enrollment_total")]
		public int? EnrollmentTotal { get; set; }

		/// <summary> "Class waiting capacity" (Official Documentation) </summary> 
		[JsonProperty("waiting_capacity")]
		public int? WaitingCapacity { get; set; }

		/// <summary> "Total current waiting students" (Official Documentation) </summary> 
		[JsonProperty("waiting_total")]
		public string WaitingTotal { get; set; }

		/// <summary> "Class discussion topic" (Official Documentation) </summary> 
		public string Topic { get; set; }

		/// <summary> "Course specific enrollment reservation data" (Official Documentation) </summary> 
		public IEnumerable<Reserves> Reserves { get; set; }

		/// <summary> "Schedule data" (Official Documentation) </summary> 
		public IEnumerable<Classes> Classes { get; set; }

		/// <summary> "A list of classes the course is held with" (Official Documentation) </summary> 
		[JsonProperty("held_with")]
		public IEnumerable<string> HeldWith { get; set; }

		/// <summary> "4 digit term representation" (Official Documentation) </summary> 
		public int? Term { get; set; }

		/// <summary> "Undergraduate or graduate course classification" (Official Documentation) </summary> 
		[JsonProperty("academic_level")]
		public string AcademicLevel { get; set; }

		/// <summary> "ISO8601 timestamp of when the data was last updated" (Official Documentation) </summary> 
		[JsonProperty("last_updated")]
		public string LastUpdated { get; set; }
	}

	/// <summary> "Course Information (by course_id)" (Official Documentation) </summary> 
	public class CourseInformationByCourseId
	{
		/// <summary> "Registrar assigned course ID" (Official Documentation) </summary> 
		[JsonProperty("course_id")]
		public string CourseId { get; set; }

		/// <summary> "Requested subject acronym" (Official Documentation) </summary> 
		public string Subject { get; set; }

		/// <summary> "Registrar assigned class number" (Official Documentation) </summary> 
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }

		/// <summary> "Class name and title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "Credit count for the mentioned course" (Official Documentation) </summary> 
		public double? Units { get; set; }

		/// <summary> "Brief course description" (Official Documentation) </summary> 
		public string Description { get; set; }

		/// <summary> "Instruction types for the course (LEC, TUT, LAB etc)" (Official Documentation) </summary> 
		public List<string> Instructions { get; set; }

		/// <summary> "Prerequisite listing for the course" (Official Documentation) </summary> 
		public string Prerequisites { get; set; }

		/// <summary> "Antirequisite listing for the course" (Official Documentation) </summary> 
		public string Antirequisites { get; set; }

		/// <summary> "Corequisite listing for the course" (Official Documentation) </summary> 
		public string Corequisites { get; set; }

		/// <summary> "Crosslisted courses" (Official Documentation) </summary> 
		public string Crosslistings { get; set; }

		/// <summary> "List of terms that the course is offered" (Official Documentation) </summary> 
		[JsonProperty("terms_offered")]
		public List<string> TermsOffered { get; set; }

		/// <summary> "Additional notes on the course" (Official Documentation) </summary> 
		public string Notes { get; set; }

		/// <summary> "Brief course description" (Official Documentation) </summary> 
		public Offerings Offerings { get; set; }

		/// <summary> "Does enrollment require the department's permission" (Official Documentation) </summary> 
		[JsonProperty("needs_department_consent")]
		public bool? NeedsDepartmentConsent { get; set; }

		/// <summary> "Does enrollment require instructor's consent" (Official Documentation) </summary> 
		[JsonProperty("needs_instructor_consent")]
		public bool? NeedsInstructorConsent { get; set; }

		/// <summary> "Any additional information associated with the course" (Official Documentation) </summary> 
		public List<string> Extra { get; set; }

		/// <summary> "Last active year the course was offered" (Official Documentation) </summary> 
		[JsonProperty("calendar_year")]
		public string CalendarYear { get; set; }

		/// <summary> "Course URL on the course calendar" (Official Documentation) </summary> 
		public string Url { get; set; }

		/// <summary> "Undergraduate or graduate course classification" (Official Documentation) </summary> 
		[JsonProperty("academic_level")]
		public string AcademicLevel { get; set; }
	}

	/// <summary> "Subject Listings" (Official Documentation) </summary> 
	public class SubjectListings
	{
		/// <summary> "Registrar assigned course ID" (Official Documentation) </summary> 
		[JsonProperty("course_id")]
		public string CourseId { get; set; }

		/// <summary> "Requested subject acronym" (Official Documentation) </summary> 
		public string Subject { get; set; }

		/// <summary> "Registrar assigned class number" (Official Documentation) </summary> 
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }

		/// <summary> "Class name and title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "Credit count for the mentioned course" (Official Documentation) </summary> 
		public double? Units { get; set; }

		/// <summary> "Brief course description" (Official Documentation) </summary> 
		public string Description { get; set; }

		/// <summary> "Undergraduate or graduate course classification" (Official Documentation) </summary> 
		[JsonProperty("academic_level")]
		public string AcademicLevel { get; set; }
	}

	/// <summary> "offerings" (Official Documentation) </summary> 
	public class Offerings
	{
		/// <summary> "Is the course offered online" (Official Documentation) </summary> 
		public bool? Online { get; set; }

		/// <summary> "Is the course only offered online" (Official Documentation) </summary> 
		[JsonProperty("online_only")]
		public bool? OnlineOnly { get; set; }

		/// <summary> "Is the course offered at St. Jerome's" (Official Documentation) </summary> 
		[JsonProperty("st_jerome")]
		public bool? StJerome { get; set; }

		/// <summary> "Is the course only offered at St. Jerome's" (Official Documentation) </summary> 
		[JsonProperty("st_jerome_only")]
		public bool? StJeromeOnly { get; set; }

		/// <summary> "Is the course offered at Renison" (Official Documentation) </summary> 
		public bool? Renison { get; set; }

		/// <summary> "Is the course only offered at Renison" (Official Documentation) </summary> 
		[JsonProperty("renison_only")]
		public bool? RenisonOnly { get; set; }

		/// <summary> "Is the course offered at Conrad Grebel" (Official Documentation) </summary> 
		[JsonProperty("conrad_grebel")]
		public bool? ConradGrebel { get; set; }

		/// <summary> "Is the course only offered at Conrad Grebel" (Official Documentation) </summary> 
		[JsonProperty("conrad_grebel_only")]
		public bool? ConradGrebelOnly { get; set; }
	}

	/// <summary> "Course Information" (Official Documentation) </summary> 
	public class CourseInformation
	{
		/// <summary> "Registrar assigned course ID" (Official Documentation) </summary> 
		[JsonProperty("course_id")]
		public string CourseId { get; set; }

		/// <summary> "Requested subject acronym" (Official Documentation) </summary> 
		public string Subject { get; set; }

		/// <summary> "Registrar assigned class number" (Official Documentation) </summary> 
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }

		/// <summary> "Class name and title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "Credit count for the mentioned course" (Official Documentation) </summary> 
		public double? Units { get; set; }

		/// <summary> "Brief course description" (Official Documentation) </summary> 
		public string Description { get; set; }

		/// <summary> "Instruction types for the course (LEC, TUT, LAB etc)" (Official Documentation) </summary> 
		public List<string> Instructions { get; set; }

		/// <summary> "Prerequisite listing for the course" (Official Documentation) </summary> 
		public string Prerequisites { get; set; }

		/// <summary> "Antirequisite listing for the course" (Official Documentation) </summary> 
		public string Antirequisites { get; set; }

		/// <summary> "Corequisite listing for the course" (Official Documentation) </summary> 
		public string Corequisites { get; set; }

		/// <summary> "Crosslisted courses" (Official Documentation) </summary> 
		public string Crosslistings { get; set; }

		/// <summary> "List of terms that the course is offered" (Official Documentation) </summary> 
		[JsonProperty("terms_offered")]
		public List<string> TermsOffered { get; set; }

		/// <summary> "Additional notes on the course" (Official Documentation) </summary> 
		public string Notes { get; set; }

		/// <summary> "Brief course description" (Official Documentation) </summary> 
		public Offerings Offerings { get; set; }

		/// <summary> "Does enrollment require the department's permission" (Official Documentation) </summary> 
		[JsonProperty("needs_department_consent")]
		public bool? NeedsDepartmentConsent { get; set; }

		/// <summary> "Does enrollment require instructor's consent" (Official Documentation) </summary> 
		[JsonProperty("needs_instructor_consent")]
		public bool? NeedsInstructorConsent { get; set; }

		/// <summary> "Any additional information associated with the course" (Official Documentation) </summary> 
		public List<string> Extra { get; set; }

		/// <summary> "Last active year the course was offered" (Official Documentation) </summary> 
		[JsonProperty("calendar_year")]
		public string CalendarYear { get; set; }

		/// <summary> "Course URL on the course calendar" (Official Documentation) </summary> 
		public string Url { get; set; }

		/// <summary> "Undergraduate or graduate course classification" (Official Documentation) </summary> 
		[JsonProperty("academic_level")]
		public string AcademicLevel { get; set; }
	}

	/// <summary> "sections" (Official Documentation) </summary> 
	public class Sections
	{
		/// <summary> "Exam section number" (Official Documentation) </summary> 
		public string Section { get; set; }

		/// <summary> "Day of the exam" (Official Documentation) </summary> 
		public string Day { get; set; }

		/// <summary> "ISO8601 exam date representation" (Official Documentation) </summary> 
		public string Date { get; set; }

		/// <summary> "Exam starting time" (Official Documentation) </summary> 
		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		/// <summary> "Exam ending time" (Official Documentation) </summary> 
		[JsonProperty("end_time")]
		public string EndTime { get; set; }

		/// <summary> "Exam location" (Official Documentation) </summary> 
		public string Location { get; set; }

		/// <summary> "Additional notes regarding the section" (Official Documentation) </summary> 
		public string Notes { get; set; }
	}

	/// <summary> "Exam Schedule" (Official Documentation) </summary> 
	public class ExamSchedule
	{
		/// <summary> "Full course name (subject and catalog number)" (Official Documentation) </summary> 
		public string Course { get; set; }

		/// <summary> "Exam schedule for all sections of the course" (Official Documentation) </summary> 
		public List<Sections> Sections { get; set; }
	}

	/// <summary> "Course Prerequisites" (Official Documentation) </summary> 
	public class CoursePrerequisites
	{
		/// <summary> "Requested subject acronym" (Official Documentation) </summary> 
		public string Subject { get; set; }

		/// <summary> "Registrar assigned class number" (Official Documentation) </summary> 
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }

		/// <summary> "Class name and title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "Raw listing of course prerequisites" (Official Documentation) </summary> 
		public string Prerequisites { get; set; }

		/// <summary> "Parsed prerequisites" (Official Documentation) </summary> 
		[JsonProperty("prerequisites_parsed")]
		public List<string> PrerequisitesParsed { get; set; }
	}

	/// <summary> "location" (Official Documentation) </summary> 
	public class Location
	{
		/// <summary> "Name of the building" (Official Documentation) </summary> 
		public string Building { get; set; }

		/// <summary> "Room double? from the building" (Official Documentation) </summary> 
		public string Room { get; set; }
	}

	/// <summary> "classes" (Official Documentation) </summary> 
	public class Classes
	{
		/// <summary> "Date object for course schedule" (Official Documentation) </summary> 
		public Date Date { get; set; }

		/// <summary> "Class location details" (Official Documentation) </summary> 
		public Location Location { get; set; }

		/// <summary> "Names of instructors teaching the course" (Official Documentation) </summary> 
		public List<string> Instructors { get; set; }
	}

	/// <summary> "Course Schedule" (Official Documentation) </summary> 
	public class CourseSchedule
	{
		/// <summary> "Requested subject acronym" (Official Documentation) </summary> 
		public string Subject { get; set; }

		/// <summary> "Registrar assigned class number" (Official Documentation) </summary> 
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }

		/// <summary> "Credit count for the mentioned course" (Official Documentation) </summary> 
		public double? Units { get; set; }

		/// <summary> "Class name and title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "Additional notes regarding enrollment for the given term" (Official Documentation) </summary> 
		public string Note { get; set; }

		/// <summary> "Associated term specific class enrollment number" (Official Documentation) </summary> 
		[JsonProperty("class_number")]
		public int? ClassNumber { get; set; }

		/// <summary> "Class instruction and number" (Official Documentation) </summary> 
		public string Section { get; set; }

		/// <summary> "Name of the campus the course is being offered" (Official Documentation) </summary> 
		public string Campus { get; set; }

		/// <summary> "Associated class id" (Official Documentation) </summary> 
		[JsonProperty("associated_class")]
		public int? AssociatedClass { get; set; }

		/// <summary> "Name of the related course component" (Official Documentation) </summary> 
		[JsonProperty("related_component_1")]
		public string RelatedComponent1 { get; set; }

		/// <summary> "Name of the second related course component" (Official Documentation) </summary> 
		[JsonProperty("related_component_2")]
		public string RelatedComponent2 { get; set; }

		/// <summary> "Class enrollment capacity" (Official Documentation) </summary> 
		[JsonProperty("enrollment_capacity")]
		public int? EnrollmentCapacity { get; set; }

		/// <summary> "Total current class enrollment" (Official Documentation) </summary> 
		[JsonProperty("enrollment_total")]
		public int? EnrollmentTotal { get; set; }

		/// <summary> "Class waiting capacity" (Official Documentation) </summary> 
		[JsonProperty("waiting_capacity")]
		public int? WaitingCapacity { get; set; }

		/// <summary> "Total current waiting students" (Official Documentation) </summary> 
		[JsonProperty("waiting_total")]
		public string WaitingTotal { get; set; }

		/// <summary> "Class discussion topic" (Official Documentation) </summary> 
		public string Topic { get; set; }

		/// <summary> "Course specific enrollment reservation data" (Official Documentation) </summary> 
		public IEnumerable<Reserves> Reserves { get; set; }

		/// <summary> "Schedule data" (Official Documentation) </summary> 
		public IEnumerable<Classes> Classes { get; set; }

		/// <summary> "A list of classes the course is held with" (Official Documentation) </summary> 
		[JsonProperty("held_with")]
		public IEnumerable<string> HeldWith { get; set; }

		/// <summary> "4 digit term representation" (Official Documentation) </summary> 
		public int? Term { get; set; }

		/// <summary> "Undergraduate or graduate course classification" (Official Documentation) </summary> 
		[JsonProperty("academic_level")]
		public string AcademicLevel { get; set; }

		/// <summary> "ISO8601 timestamp of when the data was last updated" (Official Documentation) </summary> 
		[JsonProperty("last_updated")]
		public string LastUpdated { get; set; }
	}

	/// <summary> Courses Endpoints </summary> 
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
		/// Official Method Name: Course Schedule by Class Number
		/// Description: This method returns the class schedule for a given course and term
		/// Update Frequency: Every hour
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<CourseScheduleByClassNumber>> CourseScheduleByClassNumber(int classNumber)
		{
			return ApiRequest<List<CourseScheduleByClassNumber>>.CreateApiRequest(string.Format("/courses/{0}/schedule", classNumber), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Course Information (by course_id)
		/// Description: This method returns all available information for a given course
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<CourseInformationByCourseId> CourseInformationByCourseId(int courseId)
		{
			return ApiRequest<CourseInformationByCourseId>.CreateApiRequest(string.Format("/courses/{0}", courseId), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Subject Listings
		/// Description: This method returns all the courses offered under a given subject
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<SubjectListings>> SubjectListings(string subject)
		{
			return ApiRequest<List<SubjectListings>>.CreateApiRequest("/courses/" + subject, _apiKey);
		}

		/// <summary>
		/// Official Method Name: Course Information
		/// Description: This method returns all available information for a given course
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<CourseInformation> CourseInformation(string subject, int catalogNumber)
		{
			return ApiRequest<CourseInformation>.CreateApiRequest(string.Format("/courses/{0}/{1}", subject, catalogNumber), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Exam Schedule
		/// Description: This method returns a given course's exam schedule
		/// Update Frequency: Once a day
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<ExamSchedule> ExamSchedule(string subject, int catalogNumber)
		{
			return ApiRequest<ExamSchedule>.CreateApiRequest(string.Format("/courses/{0}/{1}/examschedule", subject, catalogNumber), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Course Prerequisites
		/// Description: This method returns parsed and raw representation of prerequsites for a given course
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<CoursePrerequisites> CoursePrerequisites(string subject, int catalogNumber)
		{
			return ApiRequest<CoursePrerequisites>.CreateApiRequest(string.Format("/courses/{0}/{1}/prerequisites", subject, catalogNumber), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Course Schedule
		/// Description: This method returns the class schedule for a given course and term
		/// Update Frequency: Every hour
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<CourseSchedule>> CourseSchedule(string subject, int catalogNumber)
		{
			return ApiRequest<List<CourseSchedule>>.CreateApiRequest(string.Format("/courses/{0}/{1}/schedule", subject, catalogNumber), _apiKey);
		}

	}
}
