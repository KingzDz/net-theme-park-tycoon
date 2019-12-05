using System.Collections.Generic;
using ThemeParkTycoonGame.Core;

namespace ThemeParkTycoonGame.Fancy
{
    // Most of the methods in this class are called because .NET standard does not support System.Drawing
    // In that project we have just given images the datatype 'object' instead of System.Drawing.Image.
    // That's why we need to cast it back to an Image, when we get it from those kinds of 'object' properties
    class WpfHelper
    {
        public static void DoSetup()
        {
            CreateWeatherTypes();
            CreateRides();
            CreateProducts();

            // Set the image that appears when the ride image is not set.
            Ride.RideImageUnavailableImage = "pack://siteoforigin:,,,/Resources/unavailable_48.png";
        }

        private static void CreateWeatherTypes()
        {
            Weather.WeatherTypes = new Weather[]
            {
                new Weather("Sunny", "pack://siteoforigin:,,,/Resources/weather_sun_48.png", 1.5f),
                new Weather("Rainy", "pack://siteoforigin:,,,/Resources/weather_rain_48.png", 0.5f),
                new Weather("Stormy", "pack://siteoforigin:,,,/Resources/weather_storm_48.png", 0.25f),
                new Weather("Snow", "pack://siteoforigin:,,,/Resources/weather_snow_48.png", 0.3f),
            };
        }

        public static List<StatBoost> GetStatBoostsForPython() => new List<StatBoost>()
        {
            new StatBoost()
            {
                StatType = StatTypes.GetByUniqueId("excitement"),
                Multiplier = 2f, // Going on Python makes you twice as excited as you were
                Duration = 5,
            }
        };

        private static void CreateRides()
        {
            Rides.All = new List<Ride>()
            {
                new Ride("Baron 1898", "pack://siteoforigin:,,,/Resources/efteling_baron1898.png", 25000, 5),
                new Ride("Goliath", "pack://siteoforigin:,,,/Resources/walibi_goliath.png", 25000, 10),
                new Ride("Python", "pack://siteoforigin:,,,/Resources/efteling_python.png", 10000, 5, GetStatBoostsForPython()),
                new Ride("Robin Hood", "pack://siteoforigin:,,,/Resources/walibi_robin_hood.png", 15000, 20),
                new Ride("Vogel Rok", "pack://siteoforigin:,,,/Resources/efteling_vogelrok.png", 15000, 15),
            };
        }

        public static void CreateProducts()
        {
            Products.All = new List<Product>()
            {
                new Product("hamburger", "Hamburger met vlees, zeer lekker voor als je honger hebt", 4),
                new Product("Friet", "Franse Friet met of zonder saus", 1.43),
                new Product("Cola", "Frisdrank", 1.75),
                new Product("Hondenvoer", "Te koop voor Wicher", 10),
                new Product("Suikerspin", "Gemaakt van Suiker", 2.50),
                new Product("Knuffelbeer", "Lekker warme Knuffelbeer", 1.50),
                new Product("Citroen Ijsje", "Voor het warme weer", 2.50)
            };
        }
    }
}
