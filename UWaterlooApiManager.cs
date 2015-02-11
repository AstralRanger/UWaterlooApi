using System.Net;
using Newtonsoft.Json;

namespace UWaterlooApi.ApiRequest
{
	
	/// <summary>
	/// Meta information from each function call
	/// </summary>
	public class Meta
	{
		public int Requests, Timestamp, Status, MethodId, Version;
		public string Message;
	}
		
	/// <summary>
	/// API Call wrapper. 
	/// </summary>
	/// <typeparam name="T"> Class corresponding to "data" in the APIs returned JSON feed </typeparam>
	public class ApiRequest<T> where T : new()
	{
		public Meta Meta;
		public T Data;

		/// <summary>
		/// Default Constructor
		/// </summary>
		public ApiRequest()
		{
			Meta = new Meta();
			Data = new T();
		}

		/// <summary>
		/// Creates 
		/// </summary>
		/// <param name="apiUrl">The API endpoint to call (Should start with / and NOT include file format) </param>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public static ApiRequest<T> CreateApiRequest (string endpoint, string apiKey)
		{
			string json;

			using (var webClient = new WebClient())
			{
				json = webClient.DownloadString(string.Concat("http://api.uwaterloo.ca/v2", endpoint, ".json", "?key=", apiKey));
			}

			return JsonConvert.DeserializeObject<ApiRequest<T>>(json);
		}
	}
}
