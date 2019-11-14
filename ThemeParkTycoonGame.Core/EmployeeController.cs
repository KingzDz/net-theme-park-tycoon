using System;
using System.Collections.Generic;
using System.Text;

namespace ThemeParkTycoonGame.Core
{
    class EmployeeController
    {
        List<Employee> WorkerList = new List<Employee>();

        public EmployeeController()
        {
            WorkerList.Add(NewEmployee());

        }

        public Employee NewEmployee()
        {
            Employee worker = new Employee();
            worker.Function = "Performer";
            worker.Boost.StatType = StatTypes.GetByUniqueId("excitement");
            return worker;
        }
    }
}
