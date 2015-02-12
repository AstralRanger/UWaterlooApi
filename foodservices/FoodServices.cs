/*....By : Robinson Mann
 *..Date : 2/3/2015
 *.About : Handles the foodservices/* api endpoints
 **********************/

using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UWaterlooApi.ApiRequest;

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
		[JsonProperty("Outlet_Name")]
		public string OutletName { get; set; }
		[JsonProperty("Outlet_Id")]
		public int? OutletId { get; set; }
		public IEnumerable<OutletMenu> Menu { get; set; }
		public string Notes { get; set; }
	}

	public class OutletMenu
	{
		public string Date { get; set; }
		public string Day { get; set; }
		public Meals Meals { get; set; }
		public string Notes { get; set; }
	}

	public class Meals
	{
		public IEnumerable<Meal> Lunch { get; set; }
		public IEnumerable<Meal> Dinner { get; set; }
	}

	public class Meal
	{
		[JsonProperty("Product_Name")]
		public string ProductName { get; set; }
		[JsonProperty("Diet_Type")]
		public string DietType { get; set; }
		[JsonProperty("Product_Id")]
		public string ProductId { get; set; }
	}

	public class WeeklyFoodMenu
	{
		public Date Date { get; set; }

		public IEnumerable<Outlet> Outlets;
	}

	public class NoteComplete
	{
		public Date Date { get; set; }
		public string OutletName { get; set; }
		public int OutletId { get; set; }
		public string Note { get; set; }
	}


	public class Diet
	{
		[JsonProperty("Diet_Id")]
		public int? DietId { get; set; }

		[JsonProperty("Diet_Type")]
		public string DietType { get; set; }

	}

	public class OutletMore
	{
		[JsonProperty("Outlet_Id")]
		public int? OutletId { get; set; }
		[JsonProperty("Outlet_Name")]
		public string OutletName { get; set; }
		[JsonProperty("Has_Breakfast")]
		public bool? HasBreakfast { get; set; }
		[JsonProperty("Has_Lunch")]
		public bool? HasLunch { get; set; }
		[JsonProperty("Has_Dinner")]
		public bool? HasDinner { get; set; }
	}

	public class OutletsMore
	{
		public IEnumerable<OutletMore> Outlets;
	}

	/// <summary> Information about an outlet and its operating hours </summary>
	public class Location
	{

		/// <summary> "Outlet ID number (not always same as outlets.json method). Can be null" (Offical Documentation) </summary>
		[JsonProperty("Outlet_id")]
		public int OutletId { get; set; }

		/// <summary> "Outlet name" (Offical Documentation) </summary>
		[JsonProperty("Outlet_name")]
		public string OutletName { get; set; }

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
		[JsonProperty("Is_Open_Now")]
		public bool IsOpenNow { get; set; }

		/// <summary> "Weekly operating hours data" (Offical Documentation) </summary>
		[JsonProperty("Opening_Hours")]
		public IEnumerable<LocationOpeningHours> OpeningHours { get; set; }

		/// <summary> "Special cases for operating hours" (Offical Documentation) </summary>
		[JsonProperty("Special_Hours")]
		public IEnumerable<LocationOpeningHours> SpecialHours { get; set; }

		/// <summary> "Y-m-d format list of dates the outlet is closed" (Offical Documentation) </summary>
		[JsonProperty("Dates_Closed")]
		public IEnumerable<string> DatesClosed { get; set; } 


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
		[JsonProperty("Opening_Hour")]
		public string OpeningHour { get; set; }

		/// <summary> "Location's closing time (H:i format)" (Offical Documentation) </summary>
		[JsonProperty("Closing_Hour")]
		public string ClosingHour { get; set; }

		/// <summary> "If the location is closed on that day" (Offical Documentation) </summary>
		[JsonProperty("Is_Closed")]
		public bool IsClosed { get; set; }
	}

	/// <summary> "Special cases for operating hours" (Offical Documentation) </summary>
	public class SpecialHours
	{

		///<summary> "Y-m-d format date for the special case" (Offical Documentation) </summary>
		public string Date { get; set; }

		///<summary> "Location's opening time (H:i format)" (Offical Documentation) </summary>
		[JsonProperty("opening_hour")]
		public string OpeningHour { get; set; }

		///<summary> "Location's closing time (H:i format)" (Offical Documentation) </summary>
		[JsonProperty("closing_hour")]
		public string ClosingHour { get; set; }
	}

	public class Watcard
	{
		/// <summary> "Outlet ID number" (Offical Documentation) </summary>
		[JsonProperty("vender_id")]
		public int VendorId { get; set; }

		/// <summary> "Vendor name" (Offical Documentation) </summary>
		[JsonProperty("vendor_name")]
		public string VendorName { get; set; }
	}

	public class Announcements
	{
		/// <summary> "Advertisement date object" (Offical Documentation) </summary> 
		public string Date { get; set; }

		/// <summary> "Advertisement text" (Offical Documentation) </summary> 
		[JsonProperty("ad_text")] 
		public string AdText { get; set; }
	}

	public class Product
	{
		/// <summary> "Food item's numeric id" (Offical Documentation) </summary>
		public int Product_Id { get; set; }

		/// <summary> "Name of the food item" (Offical Documentation) </summary>
		public string Product_Name { get; set; }

		/// <summary> "Food ingredients" (Offical Documentation) </summary>
		public string Ingredients { get; set; }

		/// <summary> "Item's service size (in grams or whole)" (Offical Documentation) </summary>
		public string Serving_Size { get; set; }

		/// <summary> "Serving size in milliliters" (Offical Documentation) </summary>
		public int Serving_Size_ml { get; set; }

		/// <summary> "Serving size in grams" (Offical Documentation) </summary>
		public int Serving_Size_g { get; set; }

		/// <summary> "Food calorie count" (Offical Documentation) </summary>
		public int Calories { get; set; }

		/// <summary> "Total fat in grams" (Offical Documentation) </summary>
		public int Total_Fat_g { get; set; }

		/// <summary> "Total fat in percentage" (Offical Documentation) </summary>
		public int Total_Fat_Percent { get; set; }

		/// <summary> "Total saturated fat in grams" (Offical Documentation) </summary>
		public int Fat_Saturated_g { get; set; }

		/// <summary> "Total saturated fat in percentage" (Offical Documentation) </summary>
		public int Fat_Saturated_Percent { get; set; }

		/// <summary> "Total trans fat in grams" (Offical Documentation) </summary>
		public int Fat_Trans_g { get; set; }

		/// <summary> "Total trans fat in percentage" (Offical Documentation) </summary>
		public int Fat_Trans_Percent { get; set; }

		/// <summary> "Total cholesterol in milligrams" (Offical Documentation) </summary>
		public int Cholesterol_mg { get; set; }

		/// <summary> "Sodium in milligrams" (Offical Documentation) </summary>
		public int Sodium_mg { get; set; }

		/// <summary> "Sodium in percentage" (Offical Documentation) </summary>
		public int Sodium_Percent { get; set; }

		/// <summary> "Total carbohydrates in grams" (Offical Documentation) </summary>
		public int Carbo_g { get; set; }

		/// <summary> "Carbohydrates as percentage" (Offical Documentation) </summary>
		public int Carbo_Percent { get; set; }

		/// <summary> "Carbohydrate fibres in grams" (Offical Documentation) </summary>
		public int Carbo_Fibre_g { get; set; }

		/// <summary> "Carbohydrates fibers as percentage" (Offical Documentation) </summary>
		public int Carbo_Fibre_Percent { get; set; }

		/// <summary> "Carbohydrate sugar in grams" (Offical Documentation) </summary>
		public int Carbo_Sugars_g { get; set; }

		/// <summary> "Total protein in grams" (Offical Documentation) </summary>
		public int Protein_g { get; set; }

		/// <summary> "Total vitamin A percentage" (Offical Documentation) </summary>
		public int Vitamin_A_Percent { get; set; }

		/// <summary> "Total vitamin C percentage" (Offical Documentation) </summary>
		public int Vitamin_C_Percent { get; set; }

		/// <summary> "Total calcium percentage" (Offical Documentation) </summary>
		public int Calcium_Percent { get; set; }

		/// <summary> "Total iron percentage" (Offical Documentation) </summary>
		public int Iron_Percent { get; set; }

		/// <summary> "Micro nutrients in item" (Offical Documentation) </summary>
		public string Micro_Nutrients { get; set; }

		/// <summary> "Any eating tips for the item" (Offical Documentation) </summary>
		public string Tips { get; set; }

		/// <summary> "Foodservices given diet id" (Offical Documentation) </summary>
		public int Diet_Id { get; set; }

		/// <summary> "String representation of the diet_id" (Offical Documentation) </summary>
		public string Diet_Type { get; set; }

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
			return ApiRequest<WeeklyFoodMenu>.CreateApiRequest("/foodservices/menu", _apiKey);
		}
		
		/// <summary> "This method returns additional notes regarding food served in the current week" (Official Documentation) </summary>
		public ApiRequest<List<NoteComplete>> Notes()
		{
			return ApiRequest<List<NoteComplete>>.CreateApiRequest("/foodservices/notes", _apiKey);
		}

		/// <summary> "This method returns a list of all diets" (Official Documentation) </summary>
		public ApiRequest<List<Diet>> Diets()
		{
			return ApiRequest<List<Diet>>.CreateApiRequest("/foodservices/diets", _apiKey);
		}

		/// <summary> "This method returns a list of all outlets and their unique IDs, names and breakfast/lunch/dinner meal service indicators" (Official Documentation) </summary>
		public ApiRequest<List<OutletMore>> Outlets()
		{
			return ApiRequest<List<OutletMore>>.CreateApiRequest("/foodservices/outlets", _apiKey);
		}

		/// <summary> "This method returns a list of all outlets and their operating hour data" (Offical Documentation) </summary>
		public ApiRequest<List<Location>> Locations()
		{
			return ApiRequest<List<Location>>.CreateApiRequest("/foodservices/locations", _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <returns></returns>
		public ApiRequest<List<Watcard>> Watcard()
		{
			return ApiRequest<List<Watcard>>.CreateApiRequest("/foodservices/watcard", _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <returns></returns>
		public ApiRequest<List<Announcements>> Announcements()
		{
			return ApiRequest<List<Announcements>>.CreateApiRequest("/foodservices/announcements", _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <param name="product"></param>
		/// <returns></returns>
		public ApiRequest<List<Announcements>> Products(int product)
		{
			return ApiRequest<List<Announcements>>.CreateApiRequest("/foodservices/announcements", _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <param name="year"></param>
		/// <param name="week"></param>
		/// <returns></returns>
		public ApiRequest<WeeklyFoodMenu> Menu(int year, int week)
		{
			if (year < 0 || week <0)
				throw new InvalidDataException();

			// Generates the appropriate endpoint url
			var request = string.Format("/foodservices/{0}/{1}/menu", year, week);

			return ApiRequest<WeeklyFoodMenu>.CreateApiRequest(request, _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <param name="year"></param>
		/// <param name="week"></param>
		/// <returns></returns>
		public ApiRequest<List<NoteComplete>> Notes(int year, int week)
		{
			if (year < 0 || week < 0)
				throw new InvalidDataException();

			// Generates the appropriate endpoint url
			var request = string.Format("/foodservices/{0}/{1}/notes", year, week);

			return ApiRequest<List<NoteComplete>>.CreateApiRequest(request, _apiKey);
		}

		/// <summary>
		/// todo
		/// </summary>
		/// <param name="year"></param>
		/// <param name="week"></param>
		/// <returns></returns>
		public ApiRequest<List<Announcements>> Announcements(int year, int week)
		{
			if (year < 0 || week < 0)
				throw new InvalidDataException();

			// Generates the appropriate endpoint url
			var request = string.Format("/foodservices/{0}/{1}/announcements", year, week);

			return ApiRequest<List<Announcements>>.CreateApiRequest(request, _apiKey);
		}

	}
}
