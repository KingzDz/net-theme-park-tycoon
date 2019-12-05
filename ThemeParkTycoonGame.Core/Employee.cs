using System;
using System.Collections.Generic;
using System.Text;

namespace ThemeParkTycoonGame.Core
{
    public class Employee
    {
        public string Name { get; set; }
        public string Function { get; set; }
        public int Efficiency { get; set; } // optionele opdracht
        public decimal Salary { get; set; } = 100;

    // This decides the worker's function
    // StatTypes and their Id's can be found in StatTypes.cs
    public StatBoost Boost = new StatBoost();

        public Employee()
        {
            Name = NameGenerator.NextName();

            Boost.StatType = StatTypes.GetByUniqueId("excitement");
            Boost.Multiplier = 1.25f;
            Boost.Duration = 60;
        }

    }
}
