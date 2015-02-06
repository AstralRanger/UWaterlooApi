/*....By : Robinson Mann
 *..Date : 2/5/2015
 **********************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Runtime.CompilerServices;
using UWaterlooAPI.FoodServices;

namespace UWaterlooAPI
{
	/// <summary>
	/// UWaterlooAPI Class
	/// </summary>
    public class UWaterlooAPI
    {
		// Your API key
		readonly string apiKey;

		/// <summary>
		/// Meta information from each function call
		/// "method" not implemented
		/// </summary>
		public class meta
		{
			public int requests, timestamp, status, method_id, version;
			public string message;
		}

		/// <summary>
		/// An API wrapper. Contains two classes, the first is the API calls meta information, 
		/// and the second is the 'data' class that the API call returned.
		/// </summary>
		/// <typeparam name="T">The type of data that the API call returns</typeparam>
		public class ApiCall<T> where T : new() {
			public meta	meta;
			public T	data;

			/// <summary>
			/// Default Constructor
			/// </summary>
			public ApiCall () {
				meta = new UWaterlooAPI.meta();
				data = new T();
			}
		}
				
		
		public readonly FoodServices.FoodServicesApiFactory foodservices;
		
		/// <summary>
		/// Default constructor 
		/// </summary>
		/// <param name="apiKey">UWaterloo API Key</param>
		public UWaterlooAPI(string apiKey) {
			this.apiKey = apiKey;

			foodservices = new FoodServicesApiFactory();
		}
	}
}
