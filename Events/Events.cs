/* By Robinson Mann 
 * Licensed under the MIT License, See LICENSE.txt for more information. */

using System.Collections.Generic;
using Newtonsoft.Json;

namespace UWaterlooApi.Events
{

	/// <summary> "times" (Official Documentation) </summary> 
	public class Times
	{
		/// <summary> "ISO 8601 formatted start date" (Official Documentation) </summary> 
		public string Start { get; set; }

		/// <summary> "ISO 8601 formatted end date" (Official Documentation) </summary> 
		public string End { get; set; }
	}

	/// <summary> "Get Events for Site" (Official Documentation) </summary> 
	public class GetEventsForSite
	{
		/// <summary> "Unique event id" (Official Documentation) </summary> 
		public int? Id { get; set; }

		/// <summary> "event title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "The outlet menu list" (Official Documentation) </summary> 
		public List<Times> Times { get; set; }

		/// <summary> "Type of event" (Official Documentation) </summary> 
		public List<string> Type { get; set; }

		/// <summary> "URL of event link" (Official Documentation) </summary> 
		public string Link { get; set; }

		/// <summary> "ISO 8601 formatted updated date" (Official Documentation) </summary> 
		public string Updated { get; set; }
	}

	/// <summary> "Get Events from All Sites" (Official Documentation) </summary> 
	public class GetEventsFromAllSites
	{
		/// <summary> "Unique event id" (Official Documentation) </summary> 
		public int? Id { get; set; }

		/// <summary> "Site slug from /resources/sites" (Official Documentation) </summary> 
		public string Site { get; set; }

		/// <summary> "Full site name as from https://api.uwaterloo.ca/v2/resources/sites.{format}" (Official Documentation) </summary> 
		[JsonProperty("site_name")]
		public string SiteName { get; set; }

		/// <summary> "Event title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "The event's times" (Official Documentation) </summary> 
		public List<Times> Times { get; set; }

		/// <summary> "Type of event" (Official Documentation) </summary> 
		public List<string> Type { get; set; }

		/// <summary> "URL of event link" (Official Documentation) </summary> 
		public string Link { get; set; }

		/// <summary> "ISO 8601 formatted updated date" (Official Documentation) </summary> 
		public string Updated { get; set; }
	}

	/// <summary> "times" (Official Documentation) </summary> 
	public class EventTime
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

	/// <summary> "website" (Official Documentation) </summary> 
	public class Website
	{
		/// <summary> "Title of the link" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "URL of the link" (Official Documentation) </summary> 
		public string Url { get; set; }
	}

	/// <summary> "host" (Official Documentation) </summary> 
	public class Host
	{
		/// <summary> "Title of the link" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "URL of the link" (Official Documentation) </summary> 
		public string Url { get; set; }
	}

	/// <summary> "image" (Official Documentation) </summary> 
	public class Image
	{
		/// <summary> "Unique id of image" (Official Documentation) </summary> 
		public int? Id { get; set; }

		/// <summary> "Relative link to image file path in filename.{format}" (Official Documentation) </summary> 
		public string File { get; set; }

		/// <summary> "Image alternate text" (Official Documentation) </summary> 
		public string Alt { get; set; }

		/// <summary> "Image MIME type in "string/{format}"" (Official Documentation) </summary> 
		public string Mime { get; set; }

		/// <summary> "Image file size in bytes" (Official Documentation) </summary> 
		public int? Size { get; set; }

		/// <summary> "Image width in pixels" (Official Documentation) </summary> 
		public int? Width { get; set; }

		/// <summary> "Image height in pixels" (Official Documentation) </summary> 
		public int? Height { get; set; }

		/// <summary> "Full link to image resource" (Official Documentation) </summary> 
		public string Url { get; set; }
	}

	/// <summary> "location" (Official Documentation) </summary> 
	public class Location
	{
		/// <summary> "Unique id of location" (Official Documentation) </summary> 
		public int? Id { get; set; }

		/// <summary> "Name of location" (Official Documentation) </summary> 
		public string Name { get; set; }

		/// <summary> "Street address of location" (Official Documentation) </summary> 
		public string Street { get; set; }

		/// <summary> "Additional information regarding street address of location" (Official Documentation) </summary> 
		public string Additional { get; set; }

		/// <summary> "Name of city" (Official Documentation) </summary> 
		public string City { get; set; }

		/// <summary> "Name of province in two-letter short form" (Official Documentation) </summary> 
		public string Province { get; set; }

		/// <summary> "Postal code "in L#L #L#" format" (Official Documentation) </summary> 
		[JsonProperty("postal_code")]
		public string PostalCode { get; set; }

		/// <summary> "Full name of country" (Official Documentation) </summary> 
		public string Country { get; set; }

		/// <summary> "Event location latitude" (Official Documentation) </summary> 
		public double? Latitude { get; set; }

		/// <summary> "Event location longitude" (Official Documentation) </summary> 
		public double? Longitude { get; set; }
	}

	/// <summary> "Get Events for Site given id" (Official Documentation) </summary> 
	public class GetEventsForSiteGivenId
	{
		/// <summary> "Unique event id" (Official Documentation) </summary> 
		public int? Id { get; set; }

		/// <summary> "Event title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "Event description" (Official Documentation) </summary> 
		public string Description { get; set; }

		/// <summary> "Raw event description (includes HTML markup)" (Official Documentation) </summary> 
		[JsonProperty("description_raw")]
		public string DescriptionRaw { get; set; }

		/// <summary> "The event's times" (Official Documentation) </summary> 
		public List<EventTime> Times { get; set; }

		/// <summary> "Cost of event" (Official Documentation) </summary> 
		public string Cost { get; set; }

		/// <summary> "Audience targeted by event" (Official Documentation) </summary> 
		public List<string> Audience { get; set; }

		/// <summary> "Tags related to event" (Official Documentation) </summary> 
		public List<string> Tags { get; set; }

		/// <summary> "Type of event" (Official Documentation) </summary> 
		public List<string> Type { get; set; }

		/// <summary> "The event's website for more information" (Official Documentation) </summary> 
		public Website Website { get; set; }

		/// <summary> "The event's host" (Official Documentation) </summary> 
		public Host Host { get; set; }

		/// <summary> "Image representing the event" (Official Documentation) </summary> 
		public Image Image { get; set; }

		/// <summary> "Location of the event" (Official Documentation) </summary> 
		public Location Location { get; set; }

		/// <summary> "Full site name as from https://api.uwaterloo.ca/v2/resources/sites.{format}" (Official Documentation) </summary> 
		[JsonProperty("site_name")]
		public string SiteName { get; set; }

		/// <summary> "Site slug as from https://api.uwaterloo.ca/v2/resources/sites.{format}" (Official Documentation) </summary> 
		[JsonProperty("site_id")]
		public string SiteId { get; set; }

		/// <summary> "Unique id of revision of event" (Official Documentation) </summary> 
		[JsonProperty("revision_id")]
		public int? RevisionId { get; set; }

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

	/// <summary> Events Endpoints </summary> 
	public class EventsApi
	{

		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary> Default constructor </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public EventsApi(string apiKey)
		{
			_apiKey = apiKey;
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
		/// Official Method Name: Get Events for Site given id
		/// Description: This method returns a specific event's information given a site slug and the unique id
		/// Update Frequency: Realtime
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<GetEventsForSiteGivenId> GetEventsForSiteGivenId(string site, int id)
		{
			return ApiRequest<GetEventsForSiteGivenId>.CreateApiRequest(string.Format("/events/{0}/{1}", site, id), _apiKey);
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
