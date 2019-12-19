using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public class Ride : BuildableObject, IDesirable
    {
        public static object RideImageUnavailableImage;

        public List<StatBoost> StatisticBoosts;
        public uint Duration; // In Ticks
        public string[] DesireReasons;

        // default constructor
        public Ride()
        {
            // Default to free rides without a name or image, nor any statistic boosts
            Name = "Untitled Ride";
            Image = RideImageUnavailableImage;
            Cost = 0;
            EntryFee = 0;
            StatisticBoosts = new List<StatBoost>();

            DesireReasons = new string[]
            {
                "{0} looks awesome!",
                "I'm definitely going on {0}!",
                "{0} looks very promissing!",
                "I would love to go on {0}!",
                "{0}, here I come!",
            };

            ServesTypes = new ObjectSpecific.Types[]
            {
                ObjectSpecific.Types.Exciting
            };
        }

        public Ride(string name, object image, decimal cost, uint durationInTicks, List<StatBoost> statBoosts = null)
            :this() // This causes the defaults in the default constructor to be set
        {
            Name = name;
            Image = image;
            Cost = cost;
            Duration = durationInTicks;

            if(statBoosts != null)
                StatisticBoosts = statBoosts;
        }

        string IDesirable.GetRandomDesireReason()
        {
            int amountDesireReasons = DesireReasons.Length;

            if (amountDesireReasons == 0)
                return null;

            var randomIndex = NumberGenerator.Next(amountDesireReasons);
            return DesireReasons[randomIndex];
        }

        bool IDesirable.IsAvailable()
        {
            return this.ParentInventory != null && this.ParentInventory.Contains(this);
        }
    }
}
