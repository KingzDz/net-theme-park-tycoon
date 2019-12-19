using System;

namespace ThemeParkTycoonGame.Core
{
    public class Weather
    {
        public static Weather[] WeatherTypes;

        public string Name;
        public float Multiplier;
        public object Image; // object, because .NET Standard doesn't support System.Drawing. 
        // If we remember we put an image in a variable of type 'object', we can always get it out. Despite this being an 'object'.
        // Remember that everything inherits from object. Everything is an object.

        public Weather(string name, object image, float multiplier = 1f)
        {
            Name = name;
            Image = image;

            //This will influence how much people want to do things.
            // Rain could be 0.25, meaning people won't really ride things or come to the park.
            Multiplier = multiplier;
        }
        
        public static Weather GetRandom()
        {
            int randomIndex = NumberGenerator.Next(0, WeatherTypes.Length);

            return WeatherTypes[randomIndex];
        }
    }
}
