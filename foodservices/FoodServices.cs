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

	/// <summary> Information about an outlet and its operating hours </summary>
	public class Location
	{

		/// <summary> "Outlet ID number (not always same as outlets.json method). Can be null" (Offical Documentation) </summary>
		public int Outlet_id { get; set; }

		/// <summary> "Outlet name" (Offical Documentation) </summary>
		public string Outlet_name { get; set; }

		/// <summary> "Name of the building the outlet is located" (Offical Documentation) </summary>
		public string Building { get; set; }

		/// <summary> "URL of the outlet logo (size varies)" (Offical Documentation) </summary>
		public string Logo { get; set; }

		/// <summary> "Location latitude coordinate" (Offical Documentation) </summary>
		public float Latitude { get; set; }

		/// <summary> "Location longitude coordinate" (Offical Documentation) </summary>
		public float Longitude { get; set; }

		/// <summary> "Location blurb" (Offical Documentation) </summary>
		public string Description { get; set; }

		/// <summary> "Outlet-specific announcement" (Offical Documentation) </summary>
		public string Notice { get; set; }

		/// <summary> "Predicts if the location is currently open by taking the current time into account" (Offical Documentation) </summary>
		public bool Is_Open_Now { get; set; }

	}	

	/// <summary> "Weekly operating hours data"  (Official Documentation) </summary>
	public class LocationOpeningHours
	{
		public LocationDayOfWeekOpeningHours Sunday { get; set; }
		public LocationDayOfWeekOpeningHours Monday { get; set; }
		public LocationDayOfWeekOpeningHours Tuesday { get; set; }
		public LocationDayOfWeekOpeningHours Wednesday { get; set; }
		public LocationDayOfWeekOpeningHours Thursday { get; set; }
		public LocationDayOfWeekOpeningHours Friday { get; set; }
		public LocationDayOfWeekOpeningHours Saturday { get; set; }
	}

	/// <summary> Hours for a particular day of the week </summary>
	public class LocationDayOfWeekOpeningHours
	{
		/// <summary> "Location's opening time (H:i format)" (Offical Documentation) </summary>
		public string Opening_Hour { get; set; }

		/// <summary> "Location's closing time (H:i format)" (Offical Documentation) </summary>
		public string Closing_Hour { get; set; }

		/// <summary> "If the location is closed on that day" (Offical Documentation) </summary>
		public bool Is_Closed { get; set; }
	}

	public class FoodServicesApiService
	{
		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary> Default constructor </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public FoodServicesApiService(string apiKey)
		{
			_apiKey = apiKey;
		}

		/// <summary> "This method returns current week's food menu" (Official Documentation) </summary>
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
		
		/// <summary> "This method returns additional notes regarding food served in the current week" (Official Documentation) </summary>
		public ApiRequest<Notes> Notes()
		{
			return ApiRequest<Notes>.CreateApiRequest("http://api.uwaterloo.ca/v2/foodservices/notes.json", _apiKey);
		}

		/// <summary> "This method returns a list of all diets" (Official Documentation) </summary>
		public ApiRequest<List<Diet>> Diets()
		{
			return ApiRequest<List<Diet>>.CreateApiRequest("http://api.uwaterloo.ca/v2/foodservices/diets.json", _apiKey);
		}

		/// <summary> "This method returns a list of all outlets and their unique IDs, names and breakfast/lunch/dinner meal service indicators" (Official Documentation) </summary>
		public ApiRequest<List<OutletMore>> Outlets()
		{
			return ApiRequest<List<OutletMore>>.CreateApiRequest("http://api.uwaterloo.ca/v2/foodservices/outlets.json", _apiKey);
		}

		/// <summary> "This method returns a list of all outlets and their operating hour data" (Offical Documentation) </summary>
		public ApiRequest<List<Location>> Locations()
		{
			throw new NotImplementedException();
			//return ApiRequest<List<Location>>.CreateApiRequest("https://api.uwaterloo.ca/v2/foodservices/locations.json", _apiKey);
		}
	}
}
