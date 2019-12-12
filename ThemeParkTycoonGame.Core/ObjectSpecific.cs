using System.Collections.Generic;

namespace ThemeParkTycoonGame.Core
{
    // This represents a thing that is part of the BuildableObject
    // Something that the Guest can do/pay for
    // For stalls it could be: Drink A, Drink B, Park Map, etc
    // For rides it could be: Front Seat, Back Seat, Middle Seat (increase waiting time in queue) or Show A, Show B, Version for Handicapped users, Erratically swing seat (increases ride maintenance)
    public class ObjectSpecific
    {
        // What is this object called?
        public string Name;

        // What statistic changes does this impact
        public List<StatBoost> StatisticBoosts;

        public ObjectSpecific.Types Category { get; internal set; }

        // The types of object specifics
        public enum Types
        {
            Drink = 100,
            Food = 200,
            Exciting = 300, // front-seat
            LikeItSlow = 310, // back-seat
        }
    }
}