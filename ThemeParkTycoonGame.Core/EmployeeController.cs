using System;
using System.Collections.Generic;
using System.Text;

namespace ThemeParkTycoonGame.Core
{
    public class EmployeeController
    {
        List<Employee> WorkerList = new List<Employee>();

        bool hasTicked;

        void AddEmployee(Employee employee)
        {
            WorkerList.Add(NewEmployee("excitement"));

        }

        Employee NewEmployee(string UniqueId)
        {
            Employee worker = new Employee();
            worker.Function = "Performer";
            worker.Boost.StatType = StatTypes.GetByUniqueId(UniqueId);
            return worker;
        }

        public void DoTick(int interval)
        {
            Tick(interval);
        }

        // Beetje overgenomen van GuestController. Dit zorgt dat Employee's elke seconde doen wat ze moeten doen.
        public void Tick(int interval)
        {
            hasTicked = true;

            foreach (Employee employee in WorkerList)
            {
                if (employee.Function == "Performer")
                {
                    
                }
            }
        }
    }  
}
