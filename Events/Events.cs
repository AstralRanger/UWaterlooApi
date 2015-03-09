/* By Robinson Mann */

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UWaterlooApi.ApiRequest;

namespace UWaterlooApi.Events
{

	/// <summary> "times" (Official Documentation)
	/// Minimal time information  </summary> 
	public class ShortTime
	{
		/// <summary> "ISO 8601 formatted start date" (Official Documentation) </summary> 
		public string Start { get; set; }

		/// <summary> "ISO 8601 formatted end date" (Official Documentation) </summary> 
		public string End { get; set; }
	}

	/// <summary> "Get Events from All Sites" (Official Documentation) </summary> 
	public class GetEventsFromAllSites
	{
		/// <summary> "Unique event id" (Official Documentation) </summary> 
		public int Id { get; set; }

		/// <summary> "Site slug from /resources/sites" (Official Documentation) </summary> 
		public string Site { get; set; }

		/// <summary> "Full site name as from https://api.uwaterloo.ca/v2/resources/sites.{format}" (Official Documentation) </summary> 
		[JsonProperty("site_name")]
		public string SiteName { get; set; }

		/// <summary> "Event title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "The event's times" (Official Documentation) </summary> 
		public List<ShortTime> Times { get; set; }

		/// <summary> "Type of event" (Official Documentation) </summary> 
		public List<string> Type { get; set; }

		/// <summary> "URL of event link" (Official Documentation) </summary> 
		public string Link { get; set; }

		/// <summary> "ISO 8601 formatted updated date" (Official Documentation) </summary> 
		public string Updated { get; set; }
	}

	/// <summary> "Get Events for Site" (Official Documentation) </summary> 
	public class GetEventsForSite
	{
		/// <summary> "Unique event id" (Official Documentation) </summary> 
		public int Id { get; set; }

		/// <summary> "event title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "The outlet menu list" (Official Documentation) </summary> 
		public List<ShortTime> Times { get; set; }

		/// <summary> "Type of event" (Official Documentation) </summary> 
		public List<string> Type { get; set; }

		/// <summary> "URL of event link" (Official Documentation) </summary> 
		public string Link { get; set; }

		/// <summary> "ISO 8601 formatted updated date" (Official Documentation) </summary> 
		public string Updated { get; set; }
	}

	/// <summary> "times" (Official Documentation) 
	/// Detailed time information </summary> 
	public class LongTime
	{
		/// <summary> "ISO 8601 formatted start date" (Official Documentation) </summary> 
		public string Start { get; set; }

		/// <summary> "ISO 8601 formatted end date" (Official Documentation) </summary> 
		public string End { get; set; }

		/// <summary> "Full name of day of week for start day" (Official Documentation) </summary> 
		[JsonProperty("start_day")]
		public string StartDay { get; set; }

		/// <summary> "YYYY-MM-DD formatted start date" (Official Documentation) </summary> 
		[JsonProperty("start_date")]
		public string StartDate { get; set; }

		/// <summary> "HH:MM:SS 24 formatted start time" (Official Documentation) </summary> 
		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		/// <summary> "Full name of day of week for end day" (Official Documentation) </summary> 
		[JsonProperty("end_day")]
		public string EndDay { get; set; }

		/// <summary> "YYYY-MM-DD formatted end date" (Official Documentation) </summary> 
		[JsonProperty("end_date")]
		public string EndDate { get; set; }

		/// <summary> "HH:MM:SS 24 formatted end time" (Official Documentation) </summary> 
		[JsonProperty("end_time")]
		public string EndTime { get; set; }
	}

	/// <summary> "Get Events for Site given id" (Official Documentation) </summary> 
	public class GetEventsForSiteGivenId
	{
		/// <summary> "Unique event id" (Official Documentation) </summary> 
		public int Id { get; set; }

		/// <summary> "Event title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "Event description" (Official Documentation) </summary> 
		public string Description { get; set; }

		/// <summary> "Raw event description (includes HTML markup)" (Official Documentation) </summary> 
		[JsonProperty("description_raw")]
		public string DescriptionRaw { get; set; }

		/// <summary> "The event's times" (Official Documentation) </summary> 
		public List<LongTime> Times { get; set; }

		/// <summary> "Cost of event" (Official Documentation) </summary> 
		public string Cost { get; set; }

		/// <summary> "Audience targeted by event" (Official Documentation) </summary> 
		public List<string> Audience { get; set; }

		/// <summary> "Tags related to event" (Official Documentation) </summary> 
		public List<string> Tags { get; set; }

		/// <summary> "Type of event" (Official Documentation) </summary> 
		public List<string> Type { get; set; }

		/// <summary> "The event's website for more information" (Official Documentation) </summary> 
		public object Website { get; set; }

		/// <summary> "The event's host" (Official Documentation) </summary> 
		public object Host { get; set; }

		/// <summary> "Image representing the event" (Official Documentation) </summary> 
		public object Image { get; set; }

		/// <summary> "Location of the event" (Official Documentation) </summary> 
		public object Location { get; set; }

		/// <summary> "Full site name as from https://api.uwaterloo.ca/v2/resources/sites.{format}" (Official Documentation) </summary> 
		[JsonProperty("site_name")]
		public string SiteName { get; set; }

		/// <summary> "Site slug as from https://api.uwaterloo.ca/v2/resources/sites.{format}" (Official Documentation) </summary> 
		[JsonProperty("site_id")]
		public string SiteId { get; set; }

		/// <summary> "Unique id of revision of event" (Official Documentation) </summary> 
		[JsonProperty("revision_id")]
		public int RevisionId { get; set; }

		/// <summary> "URL of event link" (Official Documentation) </summary> 
		public string Link { get; set; }

		/// <summary> "iCal feed of event" (Official Documentation) </summary> 
		[JsonProperty("link_calendar")]
		public string LinkCalendar { get; set; }

		/// <summary> "ISO 8601 formatted updated date" (Official Documentation) </summary> 
		public string Updated { get; set; }
	}

	/// <summary> "Annual Holidays" (Official Documentation) </summary> 
	public class AnnualHolidays
	{
		/// <summary> "Name of the holiday" (Official Documentation) </summary> 
		public string Name { get; set; }

		/// <summary> "Y-m-d formatted holiday date" (Official Documentation) </summary> 
		public string Date { get; set; }
	}

	/// <summary> Event Endpoints </summary> 
	public class EventsApi
	{

		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary> Default constructor </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public EventsApi(string apiKey)
		{
			Console.WriteLine("Woo");
			Console.ReadKey();
			_apiKey = apiKey;
		}

		/// <summary>
		/// Official Method Name: Get Events from All Sites
		/// Description: This method returns a list of the upcoming 21 University of Waterloo events as crawled from all University WCMS sites
		/// Update Frequency: Realtime
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<GetEventsFromAllSites>> GetEventsFromAllSites()
		{
			return ApiRequest<List<GetEventsFromAllSites>>.CreateApiRequest("/events", _apiKey);
		}

		/// <summary>
		/// Official Method Name: Get Events for Site
		/// Description: This method returns a list of the upcoming site events given a site slug
		/// Update Frequency: Realtime
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<GetEventsForSite>> GetEventsForSite(string site)
		{
			return ApiRequest<List<GetEventsForSite>>.CreateApiRequest(string.Format("/events/{0}", site), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Get Events for Site given id
		/// Description: This method returns a specific event's information given a site slug and the unique id
		/// Update Frequency: Realtime
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<GetEventsForSiteGivenId>> GetEventsForSiteGivenId(string site, string id)
		{
			return ApiRequest<List<GetEventsForSiteGivenId>>.CreateApiRequest(String.Format("events/{0}/{1}", site, id), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Annual Holidays
		/// Description: This method returns a list of university holidays starting from 2012
		/// Update Frequency: Every year
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<AnnualHolidays>> AnnualHolidays()
		{
			return ApiRequest<List<AnnualHolidays>>.CreateApiRequest("/events/holidays", _apiKey);
		}
	}
}
