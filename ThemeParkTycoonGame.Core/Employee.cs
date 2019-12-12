using System;
using System.Collections.Generic;
using System.Text;

namespace ThemeParkTycoonGame.Core
{
    public class Employee
    {
        public string Name { get; set; }
        public string Function { get; set; }
        public char Efficiency { get; set; } // optionele opdracht
        public decimal Salary { get; set; } = 100;

    // This decides the worker's function
    // StatTypes and their Id's can be found in StatTypes.cs
    public StatBoost Boost = new StatBoost();

        public Employee(string role)
        {
            Name = NameGenerator.NextName();
            Random random = new Random();
            int Randomizer = random.Next(0, 10);

            Function = role;
            if(Function == "Performer")
            {
                Boost.StatType = StatTypes.GetByUniqueId("excitement");
            }
            /*else if(Function == "Mechanic")
            {
                
            }*/
            else
            {
                Exception exception = new Exception("This function does not exist!");
                throw exception;
            }

            Boost.Multiplier = 1.00f;
            Boost.Duration = 60;

            // Extra opdracht

            if (Randomizer == 0)
            {
                Efficiency = 'A';
                Boost.Multiplier += 0.5f;
            }
            else if (Randomizer > 0 && Randomizer <= 5)
            {
                Efficiency = 'B';
                Boost.Multiplier += 0.35f;
            }
            else if (Randomizer > 5)
            {
                Efficiency = 'C';
                Boost.Multiplier += 0.2f;
            }
        }

    }
}
