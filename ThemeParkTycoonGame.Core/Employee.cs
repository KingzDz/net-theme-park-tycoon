using System;
using System.Collections.Generic;
using System.Text;

namespace ThemeParkTycoonGame.Core
{
    public class Employee
    {
        public string Name;
        public string Function;
        public int Efficiency; // optionele opdracht
        public decimal Salary = 100;

        // This decides the worker's function
        // StatTypes and their Id's can be found in StatTypes.cs
        public StatBoost Boost = new StatBoost();

        public Employee()
        {
            Name = NameGenerator.NextName();
                       
        }

    }
}
