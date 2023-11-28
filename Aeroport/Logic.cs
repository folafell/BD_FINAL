﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroport
{
    public class Logic
    {
        public static void AddEntity<T>(T entity) where T : class
        {
            using (var context = new AeroportContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public static List<Employee> GetEmployeesNotInRole()
        {
            using (var context = new AeroportContext())
            {
                var employeesNotInRole = context.Employees
                    .Where(e => !context.Pilots.Any(p => p.PilotEmployeeId == e.EmployeeId)
                    && !context.Technicians.Any(t => t.TechnicianEmployeeId == e.EmployeeId)
                    && !context.Dispatchers.Any(d => d.DispatcherEmployeeId == e.EmployeeId)
                    && !context.Cashiers.Any(c => c.CashierEmployeeId == e.EmployeeId)
                    && !context.Stewardesses.Any(s => s.StewardessEmployeeId == e.EmployeeId)
                    && !context.Securities.Any(se => se.SecurityEmployeeId == e.EmployeeId))
                    .ToList();

                return employeesNotInRole;
            }
        }

    }
}
