using System;
using System.Globalization;

namespace umop12._2zCreatingClasses
{
	class Program
    {
		static void Main()
		{
			var city = new City();
			city.Name = "Ekaterinburg";
			city.Location = new GeoLocation();
			city.Location.Latitude = 56.50;
			city.Location.Longitude = 60.35;
			Console.WriteLine("I love {0} located at ({1}, {2})",
				city.Name,
				city.Location.Longitude.ToString(CultureInfo.InvariantCulture),
				city.Location.Latitude.ToString(CultureInfo.InvariantCulture));
			Console.ReadKey();
		}
	}
	public class City
	{
		public string Name;
		public GeoLocation Location;
	}
	public class GeoLocation
	{
		public double Latitude;
		public double Longitude;
	}
}
