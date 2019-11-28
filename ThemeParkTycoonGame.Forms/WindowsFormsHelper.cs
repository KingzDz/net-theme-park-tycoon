using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemeParkTycoonGame.Core;

namespace ThemeParkTycoonGame.Forms
{
    // Most of the methods in this class are called because .NET standard does not support System.Drawing
    // In that project we have just given images the datatype 'object' instead of System.Drawing.Image.
    // That's why we need to cast it back to an Image, when we get it from those kinds of 'object' properties
    class WindowsFormsHelper
    {
        public static void DoSetup()
        {
            CreateWeatherTypes();
            CreateRides();

            // Set the image that appears when the ride image is not set.
            Ride.RideImageUnavailableImage = Properties.Resources.unavailable_481;
        }

        private static void CreateWeatherTypes()
        {
            Weather.WeatherTypes = new Weather[]
            {
                new Weather("Sunny", Properties.Resources.weather_sun_48),
                new Weather("Rainy", Properties.Resources.weather_rain_48),
                new Weather("Stormy", Properties.Resources.weather_storm_48),
                new Weather("Snow", Properties.Resources.weather_snow_48),
            };
        }

        public static List<StatBoost> GetStatBoostsForPython() => new List<StatBoost>()
        {
            new StatBoost()
            {
                StatType = StatTypes.GetByUniqueId("excitement"),
                Multiplier = 2f, // Going on Python makes you twice as excited as you were
                Duration = 5,
            },
            new StatBoost()
            {
                StatType = StatTypes.GetByUniqueId("want_for_ride"),
                Multiplier = -2f, // Going on Python makes you not want to go on a ride again
                Duration = 50,
            }
        };
        
        private static void CreateRides()
        {
            var baron = new Ride("Baron 1898", Properties.Resources.efteling_baron1898, 25000, 5);
            var goliath = new Ride("Goliath", Properties.Resources.walibi_goliath, 25000, 10);
            var python = new Ride("Python", Properties.Resources.efteling_python, 10000, 5, GetStatBoostsForPython());
            var robinHood = new Ride("Robin Hood", Properties.Resources.walibi_robin_hood, 15000, 20);
            var vogelRok = new Ride("Vogel Rok", Properties.Resources.efteling_vogelrok, 15000, 15);
            var kraken = new Ride("Kraken", Properties.Resources.kraken, 25000, 5);
            var towerofterror = new Ride("Tower of Terror", Properties.Resources.towerofterror, 25000, 5);
            var spacemountain = new Ride("Space Mountain", Properties.Resources.spacemountain, 25000, 5);
            var hoghwartsexpress = new Ride("Hoghwarts Express", Properties.Resources.hoghwartsexpress, 25000, 5);
            var voletarium = new Ride("Voletarium", Properties.Resources.voletarium, 25000, 5);
            var kingdaka = new Ride("Kingda Ka", Properties.Resources.kingdaka, 25000, 5);
            var formularossa = new Ride("Formula Rossa", Properties.Resources.forumularossa, 25000, 5);
            var slotzilla = new Ride("Slotzilla", Properties.Resources.slotzilla, 25000, 5);
            var startours = new Ride("Star Tours", Properties.Resources.startours, 25000, 5);
            var fastandfurious = new Ride("Fast & Furious Supercharged", Properties.Resources.fastandfurioussupercharged, 25000, 5);



            Rides.All = new List<Ride>()
            {
                baron,
                goliath,
                python,
                robinHood,
                vogelRok,
                kraken,
                towerofterror,
                spacemountain,
                hoghwartsexpress,
                voletarium,
                kingdaka,
                formularossa,
                slotzilla,
                startours,
                fastandfurious
            };
        }
    }
}
