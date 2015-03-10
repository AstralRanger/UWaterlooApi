// Copyright (c) Robinson Mann
// Licensed under the MIT License, See LICENSE.txt for more information.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace uWaterlooApi.News
{

	/// <summary> "Get News from All Sites" (Official Documentation) </summary> 
	public class GetNewsFromAllSites
	{
		/// <summary> "Unique news id" (Official Documentation) </summary> 
		public int Id { get; set; }

		/// <summary> "News story title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "News site slug" (Official Documentation) </summary> 
		public string Site { get; set; }

		/// <summary> "URL of news link" (Official Documentation) </summary> 
		public string Link { get; set; }

		/// <summary> "ISO 8601 formatted publish date" (Official Documentation) </summary> 
		public string Published { get; set; }

		/// <summary> "ISO 8601 formatted update date" (Official Documentation) </summary> 
		public string Updated { get; set; }
	}

	/// <summary> "Get Events for Site" (Official Documentation) </summary> 
	public class GetEventsForSite
	{
		/// <summary> "Unique news id" (Official Documentation) </summary> 
		public int Id { get; set; }

		/// <summary> "News story title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "URL of news link" (Official Documentation) </summary> 
		public string Link { get; set; }

		/// <summary> "ISO 8601 formatted publish date" (Official Documentation) </summary> 
		public string Published { get; set; }

		/// <summary> "ISO 8601 formatted update date" (Official Documentation) </summary> 
		public string Updated { get; set; }
	}

	/// <summary> "Get News for Site given id" (Official Documentation) </summary> 
	public class GetNewsForSiteGivenId
	{
		/// <summary> "Unique news id" (Official Documentation) </summary> 
		public int Id { get; set; }

		/// <summary> "News title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "News body" (Official Documentation) </summary> 
		public string Description { get; set; }

		/// <summary> "Raw news body (includes HTML markup)" (Official Documentation) </summary> 
		[JsonProperty("description_raw")]
		public string DescriptionRaw { get; set; }

		/// <summary> "Audience targeted by news item" (Official Documentation) </summary> 
		public List<string> Audience { get; set; }

		/// <summary> "Image representing the news item" (Official Documentation) </summary> 
		public object Image { get; set; }

		/// <summary> "Site slug as from https://api.uwaterloo.ca/v2/resources/sites.{format}" (Official Documentation) </summary> 
		[JsonProperty("site_id")]
		public string SiteId { get; set; }

		/// <summary> "Full site name as from https://api.uwaterloo.ca/v2/resources/sites.{format}" (Official Documentation) </summary> 
		[JsonProperty("site_name")]
		public string SiteName { get; set; }

		/// <summary> "Unique id of revision of news item" (Official Documentation) </summary> 
		[JsonProperty("revision_id")]
		public int RevisionId { get; set; }

		/// <summary> "ISO 8601 formatted published date" (Official Documentation) </summary> 
		public string Published { get; set; }

		/// <summary> "ISO 8601 formatted updated date" (Official Documentation) </summary> 
		public string Updated { get; set; }

		/// <summary> "URL of news link" (Official Documentation) </summary> 
		public string Link { get; set; }
	}

	/// <summary> News Endpoints </summary> 
	public class NewsApi
	{

		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary> Default constructor </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public NewsApi(string apiKey)
		{
			_apiKey = apiKey;
		}

		/// <summary>
		/// Official Method Name: Get News from All Sites
		/// Description: This method returns a list of the freshest (most recently updated) 100 University of Waterloo news items as crawled from all University WCMS sites
		/// Update Frequency: Realtime
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<GetNewsFromAllSites>> GetNewsFromAllSites()
		{
			return ApiRequest<List<GetNewsFromAllSites>>.CreateApiRequest("/news", _apiKey);
		}

		/// <summary>
		/// Official Method Name: Get Events for Site
		/// Description: This method returns a list of the upcoming site's news given a site slug
		/// Update Frequency: Realtime
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<GetEventsForSite>> GetEventsForSite(string site)
		{
			return ApiRequest<List<GetEventsForSite>>.CreateApiRequest(string.Format("news/{0}", site), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Get News for Site given id
		/// Description: This method returns a specific news item's information given a site's slug and id
		/// Update Frequency: Realtime
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<GetNewsForSiteGivenId>> GetNewsForSiteGivenId(string site, string id)
		{
			return ApiRequest<List<GetNewsForSiteGivenId>>.CreateApiRequest(string.Format("news/{0}/{1}", site, id), _apiKey);
		}

	}
}
