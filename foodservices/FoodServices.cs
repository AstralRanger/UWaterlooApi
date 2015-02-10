/*....By : Robinson Mann
 *..Date : 2/3/2015
 *.About : Handles the foodservices/* api endpoints
 **********************/

using System;
using UWaterlooApi;
using System.Collections.Generic;
using System.Globalization;
using UWaterlooApi.ApiManager;

// todo: Get Newtonsoft.Json to ignore _ when mapping to objects

namespace UWaterlooApi.FoodServices
{

	public class Date
	{
		public int? Week { get; set; }
		public int? Year { get; set; }
		public string Start { get; set; }
		public string End { get; set; }
	}

	public class Outlet
	{
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
		public int? Diet_Id { get; set; }
		public string Diet_Type { get; set; }

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
		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public FoodServicesApiService(string apiKey)
		{
			_apiKey = apiKey;
		}

		/// <summary>
		/// Official Documentation
		/// </summary>
		public ApiRequest<WeeklyFoodMenu> Menu()
		{
			// TODO: Make this compliant to ISO Standards. The offical API documentation is unclear in what, if any, standards it follows
			var dateTimeUtcNow = DateTime.UtcNow;

			// Generates the appropriate endpoint url
			var request = string.Format("https://api.uwaterloo.ca/v2/foodservices/{0}/{1}/menu.json",
				dateTimeUtcNow.Year,
				CultureInfo.GetCultureInfo("en").Calendar.GetWeekOfYear(dateTimeUtcNow, CalendarWeekRule.FirstDay, DayOfWeek.Monday));


			return ApiRequest<WeeklyFoodMenu>.CreateApiRequest(request, _apiKey);
		}
		
	
		/// <summary>
		/// "This method returns additional notes regarding food served in the current week" (Official Documentation)
		/// </summary>
		public ApiRequest<Notes> Notes()
		{
			return ApiRequest<Notes>.CreateApiRequest("http://api.uwaterloo.ca/v2/foodservices/notes.json", _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		public ApiRequest<List<Diet>> Diets()
		{
			return ApiRequest<List<Diet>>.CreateApiRequest("http://api.uwaterloo.ca/v2/foodservices/diets.json", _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		public ApiRequest<List<OutletMore>> Outlets()
		{
			return ApiRequest<List<OutletMore>>.CreateApiRequest("http://api.uwaterloo.ca/v2/foodservices/outlets.json", _apiKey);
		}
	}
}
