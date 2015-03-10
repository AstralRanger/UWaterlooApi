/* By Robinson Mann */

using System.Collections.Generic;
using Newtonsoft.Json;

namespace UWaterlooApi.Weather
{

	/// <summary> "Current Weather" (Official Documentation) </summary> 
	public class CurrentWeather
	{
		/// <summary> "Station's latitude" (Official Documentation) </summary> 
		public double Latitude { get; set; }

		/// <summary> "Station's longitude" (Official Documentation) </summary> 
		public double Longitude { get; set; }

		/// <summary> "Station elevation in meters" (Official Documentation) </summary> 
		[JsonProperty("elevation_m")]
		public double ElevationM { get; set; }

		/// <summary> "iso8601 timestamp of weather recordings" (Official Documentation) </summary> 
		[JsonProperty("observation_time")]
		public string ObservationTime { get; set; }

		/// <summary> "Current temperature in celsius" (Official Documentation) </summary> 
		[JsonProperty("temperature_current_c")]
		public double TemperatureCurrentC { get; set; }

		/// <summary> "Humidex temperature in celsius" (Official Documentation) </summary> 
		[JsonProperty("humidex_c")]
		public double HumidexC { get; set; }

		/// <summary> "Windchill in celsius" (Official Documentation) </summary> 
		[JsonProperty("windchill_c")]
		public double WindchillC { get; set; }

		/// <summary> "24 hour maximum temperature in celsius" (Official Documentation) </summary> 
		[JsonProperty("temperature_24hr_max_c")]
		public double Temperature24HrMaxC { get; set; }

		/// <summary> "24 hour minimum temperature in celsius" (Official Documentation) </summary> 
		[JsonProperty("temperature_24hr_min_c")]
		public double Temperature24HrMinC { get; set; }

		/// <summary> "Precipitation reading for 15 minute interval in mm" (Official Documentation) </summary> 
		[JsonProperty("precipitation_15min_mm")]
		public double Precipitation15MinMm { get; set; }

		/// <summary> "Precipitation reading for 1 hour interval in mm" (Official Documentation) </summary> 
		[JsonProperty("precipitation_1hr_mm")]
		public double Precipitation1HrMm { get; set; }

		/// <summary> "Precipitation reading for every 24 hour interval in mm" (Official Documentation) </summary> 
		[JsonProperty("precipitation_24hr_mm")]
		public double Precipitation24HrMm { get; set; }

		/// <summary> "Relative humidity in percentage" (Official Documentation) </summary> 
		[JsonProperty("relative_humidity_percent")]
		public double RelativeHumidityPercent { get; set; }

		/// <summary> "Dew point in celsius" (Official Documentation) </summary> 
		[JsonProperty("dew_point_c")]
		public double DewPointC { get; set; }

		/// <summary> "Wind speed in km per hour" (Official Documentation) </summary> 
		[JsonProperty("wind_speed_kph")]
		public double WindSpeedKph { get; set; }

		/// <summary> "Wind direction in degrees" (Official Documentation) </summary> 
		[JsonProperty("wind_direction_degrees")]
		public double WindDirectionDegrees { get; set; }

		/// <summary> "Pressure in kilo Pascals" (Official Documentation) </summary> 
		[JsonProperty("pressure_kpa")]
		public double PressureKpa { get; set; }

		/// <summary> "Word description of the current pressure trend" (Official Documentation) </summary> 
		[JsonProperty("pressure_trend")]
		public string PressureTrend { get; set; }

		/// <summary> "Incomig radiation in watts per meter square" (Official Documentation) </summary> 
		[JsonProperty("incoming_shortwave_radiation_wm2")]
		public double IncomingShortwaveRadiationWm2 { get; set; }
	}

	/// <summary> Weather Endpoints </summary> 
	public class WeatherApi
	{

		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary> Default constructor </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public WeatherApi(string apiKey)
		{
			_apiKey = apiKey;
		}

		/// <summary>
		/// Official Method Name: Current Weather
		/// Description: This method returns the current weather details from the University of Waterloo Weather Station. http://weather.uwaterloo.ca
		/// Update Frequency: Every 15 minutes
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<CurrentWeather>> CurrentWeather()
		{
			return ApiRequest<List<CurrentWeather>>.CreateApiRequest("/weather/current", _apiKey);
		}

	}
}
