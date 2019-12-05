using System;
using System.Collections.Generic;

namespace ThemeParkTycoonGame.Core
{
    public abstract class GameObject
    {
        public int SeedId { get; internal set; }
        public List<Stat> CurrentStats;

        public GameObject()
        {
            CurrentStats = new List<Stat>();

            SeedId = NumberGenerator.Next(GameObjects.MaxSeed++);
        }
    }

    public static class GameObjects
    {
        public static int MaxSeed;
    }
}