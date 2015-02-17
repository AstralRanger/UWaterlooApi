using Newtonsoft.Json;
using UWaterlooApi.ApiRequest;

namespace UWaterlooAPI.Weather
{

	/// <summary> Information about the current weather in Waterloo </summary>
	public class CurrentWeather
	{		
		/// <summary> "Station's latitude" (Offical Documentation) </summary>
		[JsonProperty("latitude")]
		public double Latitude;
		/// <summary> "Station's longitude" (Offical Documentation) </summary>
		[JsonProperty("longitude")]
		public double Longitude;
		/// <summary> "Station elevation in meters" (Offical Documentation) </summary>
		[JsonProperty("elevation_m")]
		public double ElevationM;
		/// <summary> "iso8601 timestamp of weather recordings" (Offical Documentation) </summary>
		[JsonProperty("observation_time")]
		public string ObservationTime;
		/// <summary> "Current temperature in celsius" (Offical Documentation) </summary>
		[JsonProperty("temperature_current_c")]
		public double TemperatureCurrentC;
		/// <summary> "Humidex temperature in celsius" (Offical Documentation) </summary>
		[JsonProperty("humidex_c")]
		public double HumidexC;
		/// <summary> "Windchill in celsius" (Offical Documentation) </summary>
		[JsonProperty("windchill_c")]
		public double WindchillC;
		/// <summary> "24 hour maximum temperature in celsius" (Offical Documentation) </summary>
		[JsonProperty("temperature_24hr_max_c")]
		public double Temperature24HrMaxC;
		/// <summary> "24 hour minimum temperature in celsius" (Offical Documentation) </summary>
		[JsonProperty("temperature_24hr_min_c")]
		public double Temperature24HrMinC;
		/// <summary> "Precipitation reading for 15 minute interval in mm" (Offical Documentation) </summary>
		[JsonProperty("precipitation_15min_mm")]
		public double Precipitation15MinMm;
		/// <summary> "Precipitation reading for 1 hour interval in mm" (Offical Documentation) </summary>
		[JsonProperty("precipitation_1hr_mm")]
		public double Precipitation1HrMm;
		/// <summary> "Precipitation reading for every 24 hour interval in mm" (Offical Documentation) </summary>
		[JsonProperty("precipitation_24hr_mm")]
		public double Precipitation24HrMm;
		/// <summary> "Relative humidity in percentage" (Offical Documentation) </summary>
		[JsonProperty("relative_humidity_percent")]
		public double RelativeHumidityPercent;
		/// <summary> "Dew point in celsius" (Offical Documentation) </summary>
		[JsonProperty("dew_point_c")]
		public double DewPointC;
		/// <summary> "Wind speed in km per hour" (Offical Documentation) </summary>
		[JsonProperty("wind_speed_kph")]
		public double WindSpeedKph;
		/// <summary> "Wind direction in degrees" (Offical Documentation) </summary>
		[JsonProperty("wind_direction_degrees")]
		public double WindDirectionDegrees;
		/// <summary> "Pressure in kilopascals" (Offical Documentation) </summary>
		[JsonProperty("pressure_kpa")]
		public double PressureKpa;
		/// <summary> "Word description of the current pressure trend" (Offical Documentation) </summary>
		[JsonProperty("pressure_trend")]
		public string PressureTrend;
		/// <summary> "Incoming radiation in watts per meter square" (Offical Documentation) </summary>
		[JsonProperty("incoming_shortwave_radiation_wm2")]
		public double IncomingShortwaveRadiationWm2;
	}

	/// <summary>
	/// Weather API
	/// </summary>
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
		/// "This method returns the current weather details from the University of Waterloo Weather Station. http://weather.uwaterloo.ca" (Offical Documentation)
		/// </summary>
		/// <returns></returns>
		public ApiRequest<CurrentWeather> CurrentWeather()
		{
			return ApiRequest<CurrentWeather>.CreateApiRequest("/weather/current", _apiKey);
		}
	}
}
