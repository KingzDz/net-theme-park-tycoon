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

        public Employee(string role)
        {
            Name = NameGenerator.NextName();

            Function = role;
            if(Function == "Performer")
            {
                Boost.StatType = StatTypes.GetByUniqueId("excitement");
            }
            else if(Function == "Mechanic")
            {
                Boost.StatType = StatTypes.GetByUniqueId("excitement");
            }
            else
            {
                Exception exception = new Exception("This function does not exist!");
                throw exception;
            }
            
            Boost.Multiplier = 1.25f;
            Boost.Duration = 60;
        }

    }
}
