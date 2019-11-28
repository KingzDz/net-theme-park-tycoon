using System;
using System.Collections.Generic;
using System.Text;

namespace ThemeParkTycoonGame.Core
{
    public class EmployeeController
    {
        public List<Employee> WorkerList;
        Park Park;

        bool hasTicked;

        int timeTick;

        Random rng = new Random();

        public EmployeeController(Park park)
        {
            Park = park;
            WorkerList = Park.Employees;
        }

        public void Payday()
        {
            foreach(Employee employee in WorkerList)
            {
                Park.ParkWallet.SubtractFromBalance(employee.Salary, "Employee's salary");
            }
        }

        public void DoTick(int interval)
        {
            Tick(interval);
        }

        // Beetje overgenomen van GuestController. Dit zorgt dat Employee's elke seconde doen wat ze moeten doen.
        public void Tick(int interval)
        {
            hasTicked = true;

            if (timeTick < 60)
            {
                timeTick++;
            }
            else
            {
                Payday();
                timeTick = 0;
            }

            foreach (Employee employee in WorkerList)
            {
                if (employee.Function == "Performer")
                {
                    PerformerAction();
                }
            }
        }

        public void PerformerAction()
        {
            foreach (Guest guest in Park.Guests)
            {
                if (rng.Next(0, 6) == 0 && (guest.CurrentStats[1].Value + 4) < StatTypes.MAX_STAT)
                {
                    guest.CurrentStats[1].Value += 4;
                    Console.WriteLine(guest.Name + " | " + guest.CurrentStats[1].Type.Name + ": " + guest.CurrentStats[1].Value);
                }
            }
        }
    }  
}
