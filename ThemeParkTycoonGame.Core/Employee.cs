using System;
using System.Collections.Generic;
using System.Text;

namespace ThemeParkTycoonGame.Core
{
    class Employee
    {
        public string Name;

        public Employee()
        {
            Name = NameGenerator.NextName();
        }
    }
}
