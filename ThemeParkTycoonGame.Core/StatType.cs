using System;
using System.Collections.Generic;

namespace ThemeParkTycoonGame.Core
{
    public class StatType
    {
        public static int SeedOffset = 1337;

        public string UniqueId { get; private set; }
        public string Name { get; }
        private float baseValue { get; }
        public bool IsBaseValueGenerated { get; }
        public int BaseValueMin { get; }
        public int BaseValueMax { get; }

        public GameObjectType Target;

        // Target points towards a ride for mechanical debuffs, a guest for entertainment/thirst/hunger, a stall for replenishing stock (of drinks and food)
        public StatType(string name, float? baseValue, GameObjectType target, int baseValueRandomMin = -1, int baseValueRandomMax = int.MaxValue)
        {
            // Set the ID to name by default
            UniqueId = Name = name ?? throw new ArgumentNullException(nameof(name));
            Target = target;

            if (baseValue == null)
            {
                IsBaseValueGenerated = true;
            }
            else
            {
                this.baseValue = (float)baseValue;
            }

            BaseValueMin = baseValueRandomMin;
            BaseValueMax = baseValueRandomMax;
        }

        public StatType(string id, string name, float? baseValue, GameObjectType target, int baseValueRandomMin = -1, int baseValueRandomMax = int.MaxValue)
            :this(name, baseValue, target, baseValueRandomMin, baseValueRandomMax)
        {
            // Allow overriding the id through this constructor
            UniqueId = id;
        }

        public float GetBaseValue(GameObject forGameObject)
        {
            if(IsBaseValueGenerated)
                return (float)new Random(forGameObject.SeedId + SeedOffset++).Next(BaseValueMin, BaseValueMax);

            return baseValue;
        }
    }
}