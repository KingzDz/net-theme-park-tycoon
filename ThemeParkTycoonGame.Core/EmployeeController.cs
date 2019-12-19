
﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Forms;

namespace ThemeParkTycoonGame.Core
{
    public class EmployeeController
    {
        public ObservableCollection<Employee> WorkerList;
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
            // Betaal de werknemer
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

            // Werknemers doen hun werk
            foreach (Employee employee in WorkerList)
            {
                if (employee.Function == "Performer")
                {
                    PerformerAction(employee);
                }

                else if (employee.Function == "Maintenance")
                {
                    MaintenanceAction(employee);
                }
            }
        }

        // alle Performer-werknemers geven een boost aan de excitement van de Guests
        public void PerformerAction(Employee employee)
        {
            foreach (Guest guest in Park.Guests)
            {
                if (rng.Next(0, 6) == 0 && (guest.CurrentStats[1].Value * employee.Boost.Multiplier) < StatTypes.MAX_STAT)
                {
                    guest.CurrentStats[1].Value *= employee.Boost.Multiplier;
                    Console.WriteLine(guest.Name + " | " + guest.CurrentStats[1].Type.Name + ": " + guest.CurrentStats[1].Value);
                }
            }
        }
        public void MaintenanceAction(Employee employee)
        {
            // Dit krijgen we niet af
            //foreach (Ride ride in Park.ParkInventory.Rides)
            //{
            //    if (rng.Next(0, 6) == 0)
            //    {
            //        ride.StatisticBoosts.Add(employee.Boost);
            //    }
            //}
        }
    }  
}
