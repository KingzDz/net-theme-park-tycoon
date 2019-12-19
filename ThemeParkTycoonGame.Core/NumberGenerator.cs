using System;

namespace ThemeParkTycoonGame.Core
{
    public static class NumberGenerator
    {
        private static Random randomGenerator;

        private static void createRandomIfNotExists()
        {
            if(randomGenerator == null)
                randomGenerator = new Random();
        }

        public static double NextDouble()
        {
            createRandomIfNotExists();

            return randomGenerator.NextDouble();
        }

        public static int Next(int maxValue)
        {
            createRandomIfNotExists();

            return randomGenerator.Next(maxValue);
        }

        public static int Next(int minValue, int maxValue)
        {
            createRandomIfNotExists();

            return randomGenerator.Next(minValue, maxValue);
        }
    }
}