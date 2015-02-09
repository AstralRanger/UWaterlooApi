/*....By : Robinson Mann
 *..Date : 2/3/2015
 *.About : Handles the foodservices/* api endpoints
 **********************/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Newtonsoft.Json;

// todo: Get Newtonsoft.Json to ignore _ when mapping to objects

namespace UWaterlooAPI.FoodServices
{
	public class Date
	{
		public int? Week { get; set; }
		public int? Year { get; set; }
		public string Start { get; set; }
		public string End { get; set; }
	}

	public class Outlet {
		public string Outlet_Name { get; set; } 
		public int? Outlet_Id { get; set; }
		public IEnumerable<OutletMenu> Menu { get; set; }
		public string Notes { get; set; }
	}

	public class OutletMenu
	{
		public string Date { get; set; }
		public string Day { get; set; }
		public Meals Meals { get; set; }
		public string notes { get; set; }
	}

	public class Meals
	{
		public IEnumerable<Meal> Lunch { get; set; }
		public IEnumerable<Meal> Dinner { get; set; }
	}

	public class Meal
	{
		public string Product_Name { get; set; }
		public string Diet_Type { get; set; }
		public string Product_Id { get; set; }
	}
	
	public class WeeklyFoodMenu
	{
		public Date Date { get; set; }

		public IEnumerable<Outlet> Outlets;
	}

	public class NoteEncapsulated
	{
		public Date Date { get; set; }
		public string OutletName { get; set; }
		public int OutletId { get; set; }
		public string Note { get; set; }
	}

	public class Notes
	{
		public IEnumerable<NoteEncapsulated> notes;
	}
	
	public class Diet 
	{
		public int? Diet_Id {get;set;}
		public string Diet_Type {get;set;}

	}

	public class OutletMore
	{
		public int? Outlet_Id { get; set; }
		public string Outlet_Name { get; set; }
		public bool? Has_Breakfast { get; set; }
		public bool? Has_Lunch { get; set; }
		public bool? Has_Dinner { get; set; }
	}

	public class OutletsMore 
	{
		public IEnumerable<OutletMore> Outlets;
	}

	public class FoodServicesApiService
	{
		private readonly string _apiKey;

		public FoodServicesApiService(string apiKey)
		{
			_apiKey = apiKey;
		}
		
		/// <summary>
		/// Official Documentation
		/// </summary>
		/// <param name="apiKey">Your UWaterloo API Key</param>
		/// <returns></returns>
		public UWaterlooApi.ApiCall<WeeklyFoodMenu> Menu()
		{
			// TODO: Make this compliant to ISO Standards. The offical API documentation is unclear in what, if any, standards it follows
			var DateTimeUtcNow = DateTime.UtcNow;

			// Generates the appropriate endpoint url
			var request = string.Format("https://api.uwaterloo.ca/v2/foodservices/{0}/{1}/menu.json?key={2}",
				DateTimeUtcNow.Year,
				CultureInfo.GetCultureInfo("en").Calendar.GetWeekOfYear(DateTimeUtcNow, CalendarWeekRule.FirstDay, DayOfWeek.Monday),
				_apiKey);

			var json = new WebClient().DownloadString(request);
			var returnObject = JsonConvert.DeserializeObject<UWaterlooApi.ApiCall<WeeklyFoodMenu>>(json);

			return returnObject;
		}

		/// <summary>
		/// "This method returns additional notes regarding food served in the current week" (Official Documentation)
		/// </summary>
		/// <returns>todo</returns>
		public UWaterlooApi.ApiCall<Notes> Notes()
		{
			// Generates the appropriate endpoint url
			var request = string.Format("http://api.uwaterloo.ca/v2/foodservices/notes.json?key={0}", _apiKey);

			//Calls the endpoint
			var json = new WebClient().DownloadString(request);

			var notes = JsonConvert.DeserializeObject<UWaterlooApi.ApiCall<Notes>>(json);
			return notes;
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <returns></returns>
		public UWaterlooApi.ApiCall<List<Diet>> Diets()
		{
			// Generates the appropriate endpoint url
			var request = string.Format("http://api.uwaterloo.ca/v2/foodservices/diets.json?key={0}", _apiKey);

			//Calls the endpoint
			var json = new WebClient().DownloadString(request);

			var diets = JsonConvert.DeserializeObject<UWaterlooApi.ApiCall<List<Diet>>>(json);

			return diets;
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <returns> GET /foodservices/outlets </returns>
		public UWaterlooApi.ApiCall<List<OutletMore>> Outlets() 
		{
			// Generates the appropriate endpoint url
			var request = string.Format("http://api.uwaterloo.ca/v2/foodservices/outlets.json?key={0}", _apiKey);

			//Calls the endpoint
			var json = new WebClient().DownloadString(request);

			var outlets = JsonConvert.DeserializeObject <UWaterlooApi.ApiCall<List<OutletMore>>>(json);

			return outlets;
		}



	}
}
