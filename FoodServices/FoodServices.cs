// Copyright (c) Robinson Mann
// Licensed under the MIT License, See LICENSE.txt for more information.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace UWaterlooApi.FoodServices
{

	/// <summary> "Food Services Menu Announcements" (Official Documentation) </summary> 
	public class FoodServicesMenuAnnouncements
	{
		/// <summary> "Advertisement date object" (Official Documentation) </summary> 
		public string Date { get; set; }

		/// <summary> "Advertisement text" (Official Documentation) </summary> 
		[JsonProperty("ad_text")]
		public string AdText { get; set; }
	}

	/// <summary> "Menu date object" (Official Documentation) </summary>
	public class Date
	{
		/// <summary> "Requested week" (Official Documentation) </summary>
		public int? Week { get; set; }

		/// <summary> "Requested year" (Official Documentation) </summary>
		public int? Year { get; set; }

		/// <summary> "Starting day of the menu (Y-m-d)" (Official Documentation) </summary>
		public string Start { get; set; }

		/// <summary> "Ending day of the menu (Y-m-d)" (Official Documentation) </summary>
		public string End { get; set; }
	}

	/// <summary> Menu </summary>
	public class Menu
	{
		/// <summary> "Date of the menu (Y-m-d)" (Official Documentation) </summary> 
		public string Date { get; set; }

		/// <summary> "Day of the week" (Official Documentation) </summary> 
		public string Day { get; set; }

		/// <summary> "All the meals for the day" (Official Documentation) </summary>
		public Meals Meals { get; set; }

		/// <summary> "Additional announcements for the day" (Official Documentation) </summary>
		public string Notes { get; set; }
	}

	/// <summary> Meals </summary> 
	public class Meals
	{
		/// <summary> "Lunch menu items" (Official Documentation) </summary>
		public IEnumerable<Meal> Lunch { get; set; }

		/// <summary> "Dinner menu" (Official Documentation) </summary>
		public IEnumerable<Meal> Dinner { get; set; }
	}

	/// <summary> A Meal </summary>
	public class Meal
	{
		/// <summary> "Food item name" (Official Documentation) </summary>
		[JsonProperty("Product_Name")]
		public string ProductName { get; set; }

		/// <summary> "Type of Diet" (Official Documentation) </summary> 
		[JsonProperty("Diet_Type")]
		public string DietType { get; set; }

		/// <summary> "Food item ID" (Official Documentation) </summary>
		[JsonProperty("Product_Id")]
		public string ProductId { get; set; }
	}

	/// <summary> "lunch" (Official Documentation) </summary> 
	public class Lunch
	{
		/// <summary> "Food item name" (Official Documentation) </summary> 
		[JsonProperty("product_name")]
		public string ProductName { get; set; }

		/// <summary> "Type of diet" (Official Documentation) </summary> 
		[JsonProperty("diet_type")]
		public string DietType { get; set; }

		/// <summary> "Food item ID" (Official Documentation) </summary> 
		[JsonProperty("product_id")]
		public int? ProductId { get; set; }
	}

	/// <summary> "Food Services Diets" (Official Documentation) </summary> 
	public class FoodServicesDiets
	{
		/// <summary> "Diet ID number" (Official Documentation) </summary> 
		[JsonProperty("diet_id")]
		public int? DietId { get; set; }

		/// <summary> "Diet type" (Official Documentation) </summary> 
		[JsonProperty("diet_type")]
		public string DietType { get; set; }
	}

	/// <summary> "Weekly operating hours data" (Official Documentation) </summary>
	public class OperatingHours
	{
		/// <summary> Operating hours for Monday </summary> 
		public DailyOperatingHours Monday { get; set; }

		/// <summary> Operating hours for Tuesday </summary> 
		public DailyOperatingHours Tuesday { get; set; }
		
		/// <summary> Operating hours for Wednesday </summary> 
		public DailyOperatingHours Wednesday { get; set; }
		
		/// <summary> Operating hours for Thursday </summary> 
		public DailyOperatingHours Thursday { get; set; }
		
		/// <summary> Operating hours for Friday </summary> 
		public DailyOperatingHours Friday { get; set; }
		
		/// <summary> Operating hours for Saturday </summary> 
		public DailyOperatingHours Saturday { get; set; }
		
		/// <summary> Operating hours for Sunday </summary> 
		public DailyOperatingHours Sunday { get; set; }
	}

	/// <summary> Operating hours for a specific date </summary>
	public class DailyOperatingHours
	{
		/// <summary> "Location's opening time (H:i format)" (Official Documentation) </summary>
		[JsonProperty("opening_hour")]
		public string OpeningHour { get; set; }
		/// <summary> "Location's closing time (H:i format)" (Official Documentation) </summary>
		[JsonProperty("closing_hour")]
		public string ClosingHour { get; set; }
		/// <summary> "If the location is closed on that day" (Official Documentation) </summary>
		[JsonProperty("is_closed")]
		public bool? IsClosed { get; set; } 
	}

	/// <summary> "Special cases for operating hours" (Official Documentation) </summary> 
	public class SpecialHours
	{
		/// <summary> "Y-m-d format date for the special case" (Official Documentation) </summary> 
		public string Date { get; set; }

		/// <summary> "Location's opening time (H:i format)" (Official Documentation) </summary> 
		[JsonProperty("opening_hour")]
		public string OpeningHour { get; set; }

		/// <summary> "Location's closing time (H:i format)" (Official Documentation) </summary> 
		[JsonProperty("closing_hour")]
		public string ClosingHour { get; set; }
	}

	/// <summary> "Food Services Locations and Hours" (Official Documentation) </summary> 
	public class FoodServicesLocationsAndHours
	{
		/// <summary> "Outlet ID number (not always same as outlets.json method). Can be null" (Official Documentation) </summary> 
		[JsonProperty("outlet_id")]
		public int? OutletId { get; set; }

		/// <summary> "Outlet name" (Official Documentation) </summary> 
		[JsonProperty("outlet_name")]
		public string OutletName { get; set; }

		/// <summary> "Name of the building the outlet is located" (Official Documentation) </summary> 
		public string Building { get; set; }

		/// <summary> "URL of the outlet logo (size varies)" (Official Documentation) </summary> 
		public string Logo { get; set; }

		/// <summary> "Location latitude coordinate" (Official Documentation) </summary> 
		public double? Latitude { get; set; }

		/// <summary> "Location longitude coordinate" (Official Documentation) </summary> 
		public double? Longitude { get; set; }

		/// <summary> "Location blurb" (Official Documentation) </summary> 
		public string Description { get; set; }

		/// <summary> "Outlet-specific announcements" (Official Documentation) </summary> 
		public string Notice { get; set; }

		/// <summary> "Predicts if the location is currently open by taking the current time into account" (Official Documentation) </summary> 
		[JsonProperty("is_open_now")]
		public bool? IsOpenNow { get; set; }

		/// <summary> "Weekly operating hours data" (Official Documentation) </summary> 
		[JsonProperty("opening_hours")]
		public DailyOperatingHours OpeningHours { get; set; }

		/// <summary> "Special cases for operating hours" (Official Documentation) </summary> 
		[JsonProperty("special_hours")]
		public IEnumerable<SpecialHours> SpecialHours { get; set; }

		/// <summary> "Y-m-d format list of dates the outlet is closed" (Official Documentation) </summary> 
		[JsonProperty("dates_closed")]
		public IEnumerable<string> DatesClosed { get; set; }
	}

	/// <summary> "Food Services Menu Notes" (Official Documentation) </summary> 
	public class FoodServicesMenuNotes
	{
		/// <summary> "Menu date object" (Official Documentation) </summary> 
		public string Date { get; set; }

		/// <summary> "Outlet name as per /foodservices/outlets" (Official Documentation) </summary> 
		[JsonProperty("outlet_name")]
		public string OutletName { get; set; }

		/// <summary> "Outlet ID as per /foodservices/outlets" (Official Documentation) </summary> 
		[JsonProperty("outlet_id")]
		public int? OutletId { get; set; }

		/// <summary> "Note" (Official Documentation) </summary> 
		public string Note { get; set; }
	}

	/// <summary> "Food Services Outlets" (Official Documentation) </summary> 
	public class FoodServicesOutlets
	{
		/// <summary> "Outlet ID number" (Official Documentation) </summary> 
		[JsonProperty("outlet_id")]
		public int? OutletId { get; set; }

		/// <summary> "Outlet name" (Official Documentation) </summary> 
		[JsonProperty("outlet_name")]
		public string OutletName { get; set; }

		/// <summary> "If serves breakfast" (Official Documentation) </summary> 
		[JsonProperty("has_breakfast")]
		public bool? HasBreakfast { get; set; }

		/// <summary> "If serves lunch" (Official Documentation) </summary> 
		[JsonProperty("has_lunch")]
		public bool? HasLunch { get; set; }

		/// <summary> "If serves dinner" (Official Documentation) </summary> 
		[JsonProperty("has_dinner")]
		public bool? HasDinner { get; set; }
	}

	/// <summary> "FoodServices Product Details" (Official Documentation) </summary> 
	public class FoodServicesProductDetails
	{
		/// <summary> "Food item's numeric id" (Official Documentation) </summary> 
		[JsonProperty("product_id")]
		public int? ProductId { get; set; }

		/// <summary> "Name of the food item" (Official Documentation) </summary> 
		[JsonProperty("product_name")]
		public string ProductName { get; set; }

		/// <summary> "Food ingredients" (Official Documentation) </summary> 
		public string Ingredients { get; set; }

		/// <summary> "Item's service size (in grams or whole)" (Official Documentation) </summary> 
		[JsonProperty("serving_size")]
		public string ServingSize { get; set; }

		/// <summary> "Serving size in milliliters" (Official Documentation) </summary> 
		[JsonProperty("serving_size_ml")]
		public int? ServingSizeMl { get; set; }

		/// <summary> "Serving size in grams" (Official Documentation) </summary> 
		[JsonProperty("serving_size_g")]
		public int? ServingSizeG { get; set; }

		/// <summary> "Food calorie count" (Official Documentation) </summary> 
		public int? Calories { get; set; }

		/// <summary> "Total fat in grams" (Official Documentation) </summary> 
		[JsonProperty("total_fat_g")]
		public int? TotalFatG { get; set; }

		/// <summary> "Total fat in percentage" (Official Documentation) </summary> 
		[JsonProperty("total_fat_percent")]
		public int? TotalFatPercent { get; set; }

		/// <summary> "Total saturated fat in grams" (Official Documentation) </summary> 
		[JsonProperty("fat_saturated_g")]
		public int? FatSaturatedG { get; set; }

		/// <summary> "Total saturated fat in percentage" (Official Documentation) </summary> 
		[JsonProperty("fat_saturated_percent")]
		public int? FatSaturatedPercent { get; set; }

		/// <summary> "Total trans fat in grams" (Official Documentation) </summary> 
		[JsonProperty("fat_trans_g")]
		public int? FatTransG { get; set; }

		/// <summary> "Total trans fat in percentage" (Official Documentation) </summary> 
		[JsonProperty("fat_trans_percent")]
		public int? FatTransPercent { get; set; }

		/// <summary> "Total cholesterol in milligrams" (Official Documentation) </summary> 
		[JsonProperty("cholesterol_mg")]
		public int? CholesterolMg { get; set; }

		/// <summary> "Sodium in milligrams" (Official Documentation) </summary> 
		[JsonProperty("sodium_mg")]
		public int? SodiumMg { get; set; }

		/// <summary> "Sodium in percentage" (Official Documentation) </summary> 
		[JsonProperty("sodium_percent")]
		public int? SodiumPercent { get; set; }

		/// <summary> "Total carbohydrates in grams" (Official Documentation) </summary> 
		[JsonProperty("carbo_g")]
		public int? CarboG { get; set; }

		/// <summary> "Carbohydrates as percentage" (Official Documentation) </summary> 
		[JsonProperty("carbo_percent")]
		public int? CarboPercent { get; set; }

		/// <summary> "Carbohydrate fibres in grams" (Official Documentation) </summary> 
		[JsonProperty("carbo_fibre_g")]
		public int? CarboFibreG { get; set; }

		/// <summary> "Carbohydrates fibers as percentage" (Official Documentation) </summary> 
		[JsonProperty("carbo_fibre_percent")]
		public int? CarboFibrePercent { get; set; }

		/// <summary> "Carbohydrate sugar in grams" (Official Documentation) </summary> 
		[JsonProperty("carbo_sugars_g")]
		public int? CarboSugarsG { get; set; }

		/// <summary> "Total protein in grams" (Official Documentation) </summary> 
		[JsonProperty("protein_g")]
		public int? ProteinG { get; set; }

		/// <summary> "Total vitamin A percentage" (Official Documentation) </summary> 
		[JsonProperty("vitamin_a_percent")]
		public int? VitaminAPercent { get; set; }

		/// <summary> "Total vitamin C percentage" (Official Documentation) </summary> 
		[JsonProperty("vitamin_c_percent")]
		public int? VitaminCPercent { get; set; }

		/// <summary> "Total calcium percentage" (Official Documentation) </summary> 
		[JsonProperty("calcium_percent")]
		public int? CalciumPercent { get; set; }

		/// <summary> "Total iron percentage" (Official Documentation) </summary> 
		[JsonProperty("iron_percent")]
		public int? IronPercent { get; set; }

		/// <summary> "Micro nutrients in item" (Official Documentation) </summary> 
		[JsonProperty("micro_nutrients")]
		public string MicroNutrients { get; set; }

		/// <summary> "Any eating tips for the item" (Official Documentation) </summary> 
		public string Tips { get; set; }

		/// <summary> "Foodservices given diet id" (Official Documentation) </summary> 
		[JsonProperty("diet_id")]
		public int? DietId { get; set; }

		/// <summary> "String representation of the diet_id" (Official Documentation) </summary> 
		[JsonProperty("diet_type")]
		public string DietType { get; set; }
	}

	/// <summary> "List of all WatCard locations" (Official Documentation) </summary> 
	public class ListOfAllWatCardLocations
	{
		/// <summary> "Outlet ID number" (Official Documentation) </summary> 
		[JsonProperty("vendor_id")]
		public int? VendorId { get; set; }

		/// <summary> "Vendor name" (Official Documentation) </summary> 
		[JsonProperty("vendor_name")]
		public string VendorName { get; set; }
	}

	/// <summary> "outlets" (Official Documentation) </summary> 
	public class Outlets
	{
		/// <summary> "Name of the outlet" (Official Documentation) </summary> 
		[JsonProperty("outlet_name")]
		public string OutletName { get; set; }

		/// <summary> "Foodservices ID for the outlet" (Official Documentation) </summary> 
		[JsonProperty("outlet_id")]
		public int? OutletId { get; set; }

		/// <summary> "The outlet menu list" (Official Documentation) </summary> 
		public IEnumerable<Menu> Menu { get; set; }
	}

	/// <summary> "Weekly Food Menu" (Official Documentation) </summary> 
	public class WeeklyFoodMenu
	{
		/// <summary> "Menu date object" (Official Documentation) </summary> 
		public Date Date { get; set; }

		/// <summary> "Available outlets" (Official Documentation) </summary> 
		public IEnumerable<Outlets> Outlets { get; set; }
	}

	/// <summary> Foodservices Endpoints </summary> 
	public class FoodServicesApi
	{

		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary> Default constructor </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public FoodServicesApi(string apiKey)
		{
			_apiKey = apiKey;
		}

		/// <summary>
		/// Official Method Name: Food Services Menu Announcements
		/// Description: This method returns additional announcements regarding food served in the current week
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<FoodServicesMenuAnnouncements>> FoodServicesMenuAnnouncements()
		{
			return ApiRequest<List<FoodServicesMenuAnnouncements>>.CreateApiRequest("/foodservices/announcements", _apiKey);
		}

		/// <summary>
		/// Official Method Name: Food Services Diets
		/// Description: This method returns a list of all diets
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<FoodServicesDiets>> FoodServicesDiets()
		{
			return ApiRequest<List<FoodServicesDiets>>.CreateApiRequest("/foodservices/diets", _apiKey);
		}

		/// <summary>
		/// Official Method Name: Food Services Locations and Hours
		/// Description: This method returns a list of all outlets and their operating hour data
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<FoodServicesLocationsAndHours>> FoodServicesLocationsAndHours()
		{
			return ApiRequest<List<FoodServicesLocationsAndHours>>.CreateApiRequest("/foodservices/locations", _apiKey);
		}

		/// <summary>
		/// Official Method Name: Weekly Food Menu
		/// Description: This method returns current week's food menu.
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<WeeklyFoodMenu> WeeklyFoodMenu()
		{
			return ApiRequest<WeeklyFoodMenu>.CreateApiRequest("/foodservices/menu", _apiKey);
		}

		/// <summary>
		/// Official Method Name: Food Services Menu Notes
		/// Description: This method returns additional notes regarding food served in the current week
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<FoodServicesMenuNotes>> FoodServicesMenuNotes()
		{
			return ApiRequest<List<FoodServicesMenuNotes>>.CreateApiRequest("/foodservices/notes", _apiKey);
		}

		/// <summary>
		/// Official Method Name: Food Services Outlets
		/// Description: This method returns a list of all outlets and their unique IDs, names and breakfast/lunch/dinner meal service indicators
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<FoodServicesOutlets>> FoodServicesOutlets()
		{
			return ApiRequest<List<FoodServicesOutlets>>.CreateApiRequest("/foodservices/outlets", _apiKey);
		}

		/// <summary>
		/// Official Method Name: FoodServices Product Details
		/// Description: This method returns a product's nutritional information
		/// Update Frequency: On request (lib)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<FoodServicesProductDetails> FoodServicesProductDetails(int productId)
		{
			return ApiRequest<FoodServicesProductDetails>.CreateApiRequest(string.Format("/foodservices/products/{0}", productId), _apiKey);
		}

		/// <summary>
		/// Official Method Name: List of all WatCard locations
		/// Description: This method returns a list of all WatCard locations according to Food Services
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<ListOfAllWatCardLocations>> ListOfAllWatCardLocations()
		{
			return ApiRequest<List<ListOfAllWatCardLocations>>.CreateApiRequest("/foodservices/watcard", _apiKey);
		}

		/// <summary>
		/// Official Method Name: Food Services Menu Announcements Filtered by Week
		/// Description: This method returns additional announcements regarding food served in the week specified
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<FoodServicesMenuAnnouncements>> FoodServicesMenuAnnouncements(int year, int? week)
		{
			return ApiRequest<List<FoodServicesMenuAnnouncements>>.CreateApiRequest(string.Format("/foodservices/{0}/{1}/announcements", year, week), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Weekly Food Menu
		/// Description: This method returns the given week and year's food menu.
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<WeeklyFoodMenu> WeeklyFoodMenu(int year, int? week)
		{
			return ApiRequest<WeeklyFoodMenu>.CreateApiRequest(string.Format("/foodservices/{0}/{1}/menu", year, week), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Food Services Menu Notes Filtered by Week
		/// Description: This method returns additional notes regarding food served in the week specified
		/// Update Frequency: Every request (live)
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<FoodServicesMenuNotes>> FoodServicesMenuNotes(int year, int? week)
		{
			return ApiRequest<List<FoodServicesMenuNotes>>.CreateApiRequest(string.Format("/foodservices/{0}/{1}/notes", year, week), _apiKey);
		}

	}
}
