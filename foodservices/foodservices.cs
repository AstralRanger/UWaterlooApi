/*....By : Robinson Mann
 *..Date : 2/3/2015
 *.About : Contians all the classes need for any of the foodserivces
 *         API calls, aswell as associated factory methods. 
 **********************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Net;
using System.IO;
 
namespace UWaterlooAPI.FoodServices
{
	public class Date
	{
		public int? week { get; set; }
		public int? year { get; set; }
		public string start { get; set; }
		public string end { get; set; }
	}

	public class Outlet {
		public string outlet_name { get; set; }
		public int? outlet_id { get; set; }
		public IEnumerable<OutletMenu> menu { get; set; }
	}

	public class OutletMenu
	{
		string date { get; set; }
		string day { get; set; }
		public IEnumerable<Meals> meals { get; set; }
	}

	public class Meals
	{
		public IEnumerable<Meal> lunch { get; set; }
		public IEnumerable<Meal> dinner { get; set; }
	}

	public class Meal
	{
		public string product_name { get; set; }
		public string diet_type { get; set; }
		public int product_id { get; set; }
	}
	
	public class WeeklyFoodMenu
	{
		public Date date { get; set; }
		public IEnumerable<Outlet> outlets;
	}

	public class Note
	{
		public Date date { get; set; }
		public string outlet_name { get; set; }
		public int outlet_id { get; set; }
		public string note { get; set; }
	}

	public class Notes
	{
		public IEnumerable<Note> notes;
	}
	
	public class Diet 
	{
		public int diet_id {get;set;}
		public string diet_type {get;set;}

	}

	public class FoodServicesApiFactory
	{
		/* TODO: Have the functions actually call the API. Research Json.Net (?) -- Should be helpful in mapping fields. */

		public UWaterlooAPI.ApiCall<WeeklyFoodMenu> menu()
		{
			UWaterlooAPI.ApiCall<WeeklyFoodMenu> WeeklyFoodMenu = new UWaterlooAPI.ApiCall<WeeklyFoodMenu>();
			return WeeklyFoodMenu;
		}

		public UWaterlooAPI.ApiCall<Notes> notes()
		{
			UWaterlooAPI.ApiCall<Notes> notes = new UWaterlooAPI.ApiCall<Notes>();
			return notes;
		}
	}
}
